using System;

namespace SocialHelpApp.classes
{
    class Notification
    {
        public string Title { get; set;}
        public string Content { get; set;}
        public object TargetFilters {get; set; }

        public Notification(string Title, string Content, object TargetFilters)
        {
            this.Title = Title;
            this.Content = Content;
            this.TargetFilters = TargetFilters;
        }
    }
}