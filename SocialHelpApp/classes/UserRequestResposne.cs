using System;

namespace SocialHelpApp.classes
{
    class UserRequestResponse
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public ObjectId _id { get; set; }
        public string Topic { get; set; }
        public string Content { get; set; }
        public string Status { get; set; }
        public ObjectId RequestId {get; set; }

        public UserRequestResponse(string Topic, string Content, string Status, UserRequest UserRequestObj)
        {
            this.Content = Content;
            this.Topic = Topic;
            this.Status = Status;
            this.RequestId = UserRequestObj._id;
        }
    }
}