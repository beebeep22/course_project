using MongoDB.Driver;
using MongoDB.Bson;
using System.Collections.Generic;


namespace курсовая.classes
{
    class DbUserOperations : DbOperations
    {
        private readonly IMongoCollection<Account> _accountsCollection;
        private readonly IMongoCollection<UserRequest> _userRequestsCollection;
        private readonly IMongoCollection<UserRequestResponse> _userRequestsResponseCollection;

        public DbUserOperations() : base()
        {
            _accountsCollection = Database.GetCollection<Account>("account");
            _userRequestsCollection = Database.GetCollection<UserRequest>("user_request");
            _userRequestsResponseCollection = Database.GetCollection<UserRequestResponse>("user_request_response");

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
    }
}
