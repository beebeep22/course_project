﻿using MongoDB.Driver;
using MongoDB.Bson;
using System.Collections.Generic;
using System;
using System.Linq;



namespace курсовая.classes
{
    class DbUserOperations : DbOperations
    {
        private readonly IMongoCollection<Account> _accountsCollection;
        private readonly IMongoCollection<UserRequest> _userRequestsCollection;
        private readonly IMongoCollection<UserRequestResponse> _userRequestsResponseCollection;
        private readonly IMongoCollection<Notification> _notificationsCollection;
        private readonly IMongoCollection<MarkedAsReadRequest> _markedAsReadRequestsCollection;

        public DbUserOperations() : base()
        {
            _accountsCollection = Database.GetCollection<Account>("account");
            _userRequestsCollection = Database.GetCollection<UserRequest>("user_request");
            _userRequestsResponseCollection = Database.GetCollection<UserRequestResponse>("user_request_response");
            _notificationsCollection = Database.GetCollection<Notification>("notification");
            _markedAsReadRequestsCollection = Database.GetCollection<MarkedAsReadRequest>("marked_as_read_requests");
        }

        public void UpdateUserDetails(Account AccountObj, UserDetails NewUserDetails)
        {
            var filter = Builders<Account>.Filter.Eq("_id", AccountObj._id);
            var update = Builders<Account>.Update.Set("UserDetails", NewUserDetails);

            _accountsCollection.UpdateOne(filter, update);
            AccountObj.UpdateUserDetails(NewUserDetails);
        }

        public void SendUserRequest(UserRequest Request)
        {
            _userRequestsCollection.InsertOne(Request);
        }

        public List<UserRequest> GetUserRequests(Account AccountObj)
        {
            ObjectId ApplicantId = AccountObj._id;
            var filter = Builders<UserRequest>.Filter.Eq("ApplicantId", ApplicantId);
            return _userRequestsCollection.Find(filter).ToList();
        }

        private List<UserRequest> GetRespondedUserRequests(Account AccountObj)
        {
            List<UserRequest> requestsWithResponses = GetUserRequestsWithResponses(AccountObj);
            List<UserRequest> respondedUserRequests = requestsWithResponses
                .Where(request => request.Response != null)
                .ToList();
            return respondedUserRequests;
        }

        public List<UserRequest> GetRequestsWithUnreadResponses(Account AccountObj)
        {
            List<UserRequest> respondedRequests = GetRespondedUserRequests(AccountObj);
            var filter = Builders<MarkedAsReadRequest>.Filter.Empty;
            List<MarkedAsReadRequest> allReadRequests = _markedAsReadRequestsCollection.Find(filter).ToList();
            List<ObjectId> readRequestIds = allReadRequests.Select(readRequest => readRequest.RequestId).ToList();
            List<UserRequest> unreadRespondedRequests = respondedRequests.Where(request => !readRequestIds.Contains(request._id)).ToList();
            return unreadRespondedRequests;

        }

        public void MarkRequestAsRead(UserRequest Request)
        {
            MarkedAsReadRequest markedAsReadRequest = new MarkedAsReadRequest(Request);
            _markedAsReadRequestsCollection.InsertOne(markedAsReadRequest);
        }

        public List<UserRequest> FillUserRequestsWithAnswers(List<UserRequest> userRequests)
        {
            foreach (var userRequest in userRequests)
            {
                var userRequestResponse = _userRequestsResponseCollection
                    .Find(x => x.UserRequestId == userRequest._id)
                    .FirstOrDefault();

                if (userRequestResponse != null)
                {
                    userRequest.SetResponse(userRequestResponse);
                }
            }

            return userRequests;
        }

        public List<UserRequest> GetUserRequestsWithResponses(Account AccountObj)
        {
            var userRequests = GetUserRequests(AccountObj);
            return FillUserRequestsWithAnswers(userRequests);
        }


        public List<Notification> GetNotifications(Account accountObj)
        {
            List<Notification> allNotifications = _notificationsCollection.Find(_ => true).ToList();

            List<Notification> filteredNotifications = new List<Notification>();

            foreach (var notification in allNotifications)
            {
                if (IsNotificationTargeted(notification, accountObj))
                {
                    filteredNotifications.Add(notification);
                }
            }

            return filteredNotifications;
        }

        private bool IsNotificationTargeted(Notification notification, Account accountObj)
        {
            UserDetails userDetails = accountObj.UserDetails;
            TargetFilters filters = notification.Filters;

            if (filters == null || filters.GetType().GetProperties().Length == 0 ||
                (!string.IsNullOrEmpty(filters.AgeFrom) && Convert.ToInt32(filters.AgeFrom) > Convert.ToInt32(userDetails.Age)) ||
                (!string.IsNullOrEmpty(filters.AgeTo) && Convert.ToInt32(filters.AgeTo) < Convert.ToInt32(userDetails.Age)) ||
                (!string.IsNullOrEmpty(filters.Gender) && !filters.Gender.Equals(userDetails.Gender, StringComparison.OrdinalIgnoreCase)) ||
                (!string.IsNullOrEmpty(filters.Region) && !filters.Region.Equals(userDetails.Region, StringComparison.OrdinalIgnoreCase)) ||
                (!string.IsNullOrEmpty(filters.Diseases) && !filters.Diseases.Equals(userDetails.Diseases, StringComparison.OrdinalIgnoreCase)) ||
                (!string.IsNullOrEmpty(filters.DisabilityLevel) && !filters.DisabilityLevel.Equals(userDetails.DisabilityLevel, StringComparison.OrdinalIgnoreCase)) ||
                (!string.IsNullOrEmpty(filters.Allergies) && !filters.Allergies.Equals(userDetails.Allergies, StringComparison.OrdinalIgnoreCase)))
            {
                return false;
            }
            return true;

        }

    }
}
