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
        
        public DbAdminOperations() : base()
        {

            _accountsCollection = Database.GetCollection<Account>("account");
            _userRequestsCollection = Database.GetCollection<UserRequest>("user_request");
            _userRequestsResponseCollection = Database.GetCollection<UserRequestResponse>("user_request_response");
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


        public List<UserRequest> FillRequestsWithApplicants(List<UserRequest> userRequests)
        {
            var unansweredRequests = new List<UserRequest>();

            foreach (var request in userRequests)
            {
                // Fetch the Account object using the ApplicantId
                Account applicantObj = GetApplicantById(request.ApplicantId);
                if (applicantObj == null) continue; // Don't add requests with unknown applicants
                request.SetApplicantObj(applicantObj);

                unansweredRequests.Add(request);
            }

            return unansweredRequests;
        }


        public List<UserRequest> GetUserRequests()
        {
            var allRequests = GetAllRequests();
            return FillRequestsWithApplicants(allRequests);
        }

        public void CreateNotification(Notification notification)
        {
            
        }
    }
}
