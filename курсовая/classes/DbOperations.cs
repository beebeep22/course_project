using System;
using System.Security.Cryptography;
using MongoDB.Driver;
using System.Text;

namespace SocialHelpApp.classes
{
    abstract class DbOperations
    {
        protected IMongoDatabase Database { get; set; }

        protected DbOperations()
        {
            DbSession session = DbSession.Instance;
            Database = session.GetDatabase();
        }

        protected string ComputeHash(string input)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] hashedBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(input));
                return BitConverter.ToString(hashedBytes).Replace("-", "").ToLower();
            }
        }
    }
}
