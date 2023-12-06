using System;
using MongoDB.Driver;
using MongoDB.Bson;


namespace курсовая.classes
{
    class DbAccountOperations : DbOperations
    {
        private readonly IMongoCollection<Account> _accountsCollection;

        public DbAccountOperations() : base()
        {
            _accountsCollection = Database.GetCollection<Account>("account");
        }

        public void UpdateAccountProfileImage(Account AccountObj, string imagePath)
        {
            AccountObj.SetProfilePhoto(imagePath);
            var filter = Builders<Account>.Filter.Eq("_id", AccountObj._id);
            var update = Builders<Account>.Update.Set("ProfileImage", AccountObj.ProfileImage);
            _accountsCollection.UpdateOne(filter, update);
        }

        public Account GetAccountByUsernameAndPassword(LoginInput input)
        {
            var filter = Builders<Account>.Filter.Eq("Username", input.Username) &
                         Builders<Account>.Filter.Eq("Password", ComputeHash(input.Password));
            var account = _accountsCollection.Find(filter).FirstOrDefault();
            return account;
        }

        public bool IsUsernameAlreadyExists(string Username)
        {
            var filter = Builders<Account>.Filter.Eq("Username", Username);
            var account = _accountsCollection.Find(filter).FirstOrDefault();
            return account != null;

        }

        public Account CreateUserAccountByUsernameAndPassword(LoginInput input)
        {
            var hashedPassword = ComputeHash(input.Password);
            var newAccount = new Account(input.Username, hashedPassword, "user");
            _accountsCollection.InsertOne(newAccount);
            return newAccount;
        }

        public void _LogAllAccounts()
        {
            var allAccounts = _accountsCollection.Find(FilterDefinition<Account>.Empty).ToList();

            Console.WriteLine("All Accounts:");
            foreach (var account in allAccounts)
            {
                Console.WriteLine($"Username: {account.Username}, Password: {account.Password}, Role: {account.Role}");
            }
        }
        public void removeAccount(Account accountObj)
        {
            var filter = Builders<Account>.Filter.Eq("_id", accountObj._id);
            _accountsCollection.DeleteOne(filter);
        }

        public void ChangePassword(Account accountObj, string NewPassword)
        {
            var newHashedPassword = ComputeHash(NewPassword);
            accountObj.Password = newHashedPassword;
            var filter = Builders<Account>.Filter.Eq("_id", accountObj._id);
            var update = Builders<Account>.Update.Set("Password", newHashedPassword);

            _accountsCollection.UpdateOne(filter, update);
        }
    }
}
