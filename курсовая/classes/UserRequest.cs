using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace курсовая.classes
{
    class UserRequest
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public ObjectId _id { get; set; }
        public string Topic { get; set; }
        public string Content { get; set; }
        public ObjectId ApplicantId { get; set; }
        public UserRequestResponse Response { get; set; }

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
    }
}