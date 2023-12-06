using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System.IO;
using System;

namespace курсовая.classes
{
    public class Account
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public ObjectId _id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }
        public byte[] ProfileImage { get; set; }

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

        public void UpdateAdminDetails(AdminDetails NewAdminDetails)
        {
            this.AdminDetails = NewAdminDetails;
        }

        public void SetProfilePhoto(string imagePath)
        {
            this.ProfileImage = File.ReadAllBytes(imagePath);
        }
    }
}
