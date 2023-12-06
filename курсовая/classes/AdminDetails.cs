using System;

namespace курсовая.classes
{
    public class AdminDetails
    {
        public bool CanRespondOnRequests { get; set; }

        public bool CanCreateNotifications {get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MiddleName { get; set; }

        public AdminDetails(bool CanRespondOnRequests, bool CanCreateNotifications, string FirstName = null, string LastName = null, string MiddleName = null)
        {
            this.CanRespondOnRequests = CanRespondOnRequests;
            this.CanCreateNotifications = CanCreateNotifications;
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.MiddleName = MiddleName;
        }

    }
}
