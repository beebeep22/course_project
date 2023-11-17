using System;

namespace курсовая.classes
{
    public class UserDetails
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MiddleName { get; set; }
        public string Gender { get; set; }
        public int Age { get; set; }
        public string City { get; set; }
        public string Diseases { get; set; }
        public string Allergies { get; set;  }
        public string DisabilityLevel { get; set; }

        public UserDetails(
            string FirstName,
            string LastName,
            string MiddleName,
            int Age,
            string City,
            string Diseases = "",
            string Allergies = "",
            string DisabilityLevel = ""
        )
        {
            this.FirstName = FirstName;
            this.LastName = LastName;       
            this.MiddleName = MiddleName;
            this.Age = Age;
            this.City = City;
            this.Diseases = Diseases;
            this.Allergies = Allergies;
            this.DisabilityLevel = DisabilityLevel;
        }

        public string GetFullName()
        {
            return this.LastName + " " + this.FirstName + " " + this.MiddleName;
        }
    }
}
