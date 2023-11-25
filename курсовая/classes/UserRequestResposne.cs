using System;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace курсовая.classes
{
    public class UserRequestResponse
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public ObjectId _id { get; set; }
        public string Topic { get; set; }
        public string Content { get; set; }
        public string Status { get; set; }
        public ObjectId UserRequestId { get; set; }

        public UserRequestResponse(string Topic, string Content, string Status, UserRequest UserRequestObj)
        {
            this._id = ObjectId.GenerateNewId();
            this.Content = Content;
            this.Status = Status;
            this.UserRequestId = UserRequestObj._id;
        }
    }
}