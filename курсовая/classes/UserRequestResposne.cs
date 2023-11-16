using System;

namespace SocialHelpApp.classes
{
    class UserRequestResponse
    {
        public string Topic { get; set; }
        public string Content { get; set; }
        public string Status { get; set; }
        public UserRequest UserRequestObj { get; set; }

        public UserRequestResponse(string Topic, string Content, string Status, UserRequest UserRequestObj)
        {
            this.Content = Content;
            this.Topic = Topic;
            this.Status = Status;
            this.UserRequestObj = UserRequestObj;
        }
    }
}