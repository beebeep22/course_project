using System;
using MongoDB.Bson;

namespace курсовая.classes
{
    class UserRequestResponse
    {
        public string Content { get; set; }
        public string Status { get; set; }
        public ObjectId UserRequestId { get; set; }

        public UserRequestResponse(string Content, string Status, UserRequest UserRequestObj)
        {
            this.Content = Content;
            this.Status = Status;
            this.UserRequestId = UserRequestObj._id;
        }
    }
}