using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace SocialHelpApp.classes
{
    public class Account
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public ObjectId _id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }

        public UserDetails UserDetails { get; set; }
        public AdminDetails AdminDetails { get; set; }


        public Account(string Username, string Password, string Role, UserDetails userDetails = null, AdminDetails adminDetails = null)
        {
            this._id = ObjectId.GenerateNewId();
            this.Username = Username;
            this.Password = Password;
            this.Role = Role;
            this.UserDetails = userDetails;
            this.AdminDetails = adminDetails;
        }


        public void UpdateUserDetails(UserDetails NewUserDetails)
        {
            this.UserDetails = NewUserDetails;
        }
    }
}
