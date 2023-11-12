using MongoDB.Driver;
using MongoDB.Bson;
using System.Collections.Generic;


namespace SocialHelpApp.classes
{
    class DbUserOperations : DbOperations
    {
        private readonly IMongoCollection<Account> _accountsCollection;
        private readonly IMongoCollection<UserRequest> _userRequestsCollection;

        public DbUserOperations() : base()
        {
            _accountsCollection = Database.GetCollection<Account>("account");
            _userRequestsCollection = Database.GetCollection<UserRequest>("user_request");
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

        public List<UserRequest> GetUserRequests(ObjectId ApplicantId)
        {
            var filter = Builders<UserRequest>.Filter.Eq("ApplicantId", ApplicantId);
            return _userRequestsCollection.Find(filter).ToList();
        }
    }
}
