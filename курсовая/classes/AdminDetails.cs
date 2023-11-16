using System;

namespace SocialHelpApp.classes
{
    public class AdminDetails
    {
        public bool CanRespondOnRequests { get; set; }

        public bool CanCreateNotifications {get; set; }

        public AdminDetails(bool CanRespondOnRequests, bool CanCreateNotifications)
        {
            this.CanRespondOnRequests = CanRespondOnRequests;
            this.CanCreateNotifications = CanCreateNotifications;
        }
    }
}
