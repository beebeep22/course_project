using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System.IO;

namespace курсовая.classes
{
    public class UserRequest
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public ObjectId _id { get; set; }
        public string Topic { get; set; }
        public string Content { get; set; }
        public ObjectId ApplicantId { get; set; }
        public UserRequestResponse Response { get; set; }
        public Account ApplicantObj { get; set; }
        public byte[] ProofImageData { get; set; }

        public UserRequest(string Topic, string Content, Account AccountObj)
        {
            this._id = ObjectId.GenerateNewId();
            this.Topic = Topic;
            this.Content = Content;
            this.ApplicantId = AccountObj._id;
        }

        public void SetResponse(UserRequestResponse Response)
        {
            this.Response = Response;
        }

        public void SetApplicantObj(Account AccountObj)
        {
            this.ApplicantObj = AccountObj;
        }


        public void LoadProofImage(string imagePath)
        {
            this.ProofImageData = File.ReadAllBytes(imagePath);
        }
    }
}