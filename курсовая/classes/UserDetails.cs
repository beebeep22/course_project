
namespace курсовая.classes
{
    public class UserDetails
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MiddleName { get; set; }
        public string Gender { get; set; }
        public string Age { get; set; }
        public string Region { get; set; }
        public string Diseases { get; set; }
        public string Allergies { get; set;  }
        public string DisabilityLevel { get; set; }
        public bool Approved { get; set; }

        public UserDetails(
            string FirstName,
            string LastName,
            string MiddleName,
            string Gender,
            string Age,
            string Region = "",
            string Diseases = "",
            string Allergies = "",
            string DisabilityLevel = ""
        )
        {
            this.FirstName = FirstName;
            this.LastName = LastName;       
            this.MiddleName = MiddleName;
            this.Gender = Gender;
            this.Age = Age;
            this.Region = Region;
            this.Diseases = Diseases;
            this.Allergies = Allergies;
            this.DisabilityLevel = DisabilityLevel;
            this.Approved = false;
        }

        public string GetFullName()
        {
            return this.LastName + " " + this.FirstName + " " + this.MiddleName;
        }

    }
}
