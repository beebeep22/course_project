using MongoDB.Driver;
using MongoDB.Bson;
using System.Collections.Generic;

namespace курсовая.classes
{
    class DbAdminOperations : DbOperations
    {
        private readonly IMongoCollection<Account> _accountsCollection;
        private readonly IMongoCollection<UserRequest> _userRequestsCollection;
        private readonly IMongoCollection<UserRequestResponse> _userRequestsResponseCollection;
        private readonly IMongoCollection<Notification> _notificationsCollection;
        
        public DbAdminOperations() : base()
        {

            _accountsCollection = Database.GetCollection<Account>("account");
            _userRequestsCollection = Database.GetCollection<UserRequest>("user_request");
            _userRequestsResponseCollection = Database.GetCollection<UserRequestResponse>("user_request_response");
            _notificationsCollection = Database.GetCollection<Notification>("notification");
        }

        public Account GetApplicantById(ObjectId ApplicantId)
        {
            return _accountsCollection
                .Find(a => a._id == ApplicantId)
                .FirstOrDefault();
        }

        public List<UserRequest> GetAllRequests()
        {
            return _userRequestsCollection.Find(new BsonDocument()).ToList();
        }


        public List<UserRequest> FillRequestsWithApplicantsAndFilterByNotRejected(List<UserRequest> userRequests)
        {
            var filledRequests = new List<UserRequest>();

            foreach (var request in userRequests)
            {
                // Fetch the Account object using the ApplicantId
                Account applicantObj = GetApplicantById(request.ApplicantId);
                if (applicantObj == null) continue; // Don't add requests with unknown applicants
                request.SetApplicantObj(applicantObj);

                var userRequestResponse = _userRequestsResponseCollection
                    .Find(x => x.UserRequestId == request._id)
                    .FirstOrDefault();

                if (userRequestResponse != null)
                {
                    request.SetResponse(userRequestResponse);
                }
                if (userRequestResponse?.Status == null || userRequestResponse.Status != "Відхилено")
                {
                    filledRequests.Add(request);
                }
            }

            return filledRequests;
        }


        public List<UserRequest> GetUserRequests()
        {
            var allRequests = GetAllRequests();
            return FillRequestsWithApplicantsAndFilterByNotRejected(allRequests);
        }

        public void CreateNotification(Notification Notification)
        {
            _notificationsCollection.InsertOne(Notification);        
        }


        private void DeleteOldResponses(UserRequestResponse Response)
        {
            var filter = Builders<UserRequestResponse>.Filter.Eq("UserRequestId", Response.UserRequestId);
            _userRequestsResponseCollection.DeleteMany(filter);
        }

        public void CreateUserRequestResponse(UserRequestResponse Response)
        {
            DeleteOldResponses(Response);
            _userRequestsResponseCollection.InsertOne(Response);
        }
    }
}
