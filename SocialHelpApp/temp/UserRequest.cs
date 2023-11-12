
using System;

namespace SocialHelpApp
{
    class UserRequest
    {
        public string Topic { get; set; }
        public string Content { get; set; }
        public User UserObj { get; set; }

        public UserRequest(string Topic, string Content, User UserObj)
        {
            this.Topic = Topic;
            this.Content = Content;
            this.UserObj = UserObj;
        }
    }
}