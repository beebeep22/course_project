using System;
using MongoDB.Bson;
using MongoDB.Driver;

namespace SocialHelpApp.classes
{
    class DbSession
    {
        private static DbSession _instance;
        private IMongoDatabase Database { get; set; }

        private DbSession()
        {
            ConnectDb();
        }

        // Method to get the singleton instance
        public static DbSession Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new DbSession();
                }
                return _instance;
            }
        }

        public IMongoDatabase GetDatabase()
        {
            if (Database == null)
            {
                ConnectDb();
            }
            return Database;
        }
        
        private void ConnectDb()
        {
            try
            {
                const string DbConnectionString = "mongodb+srv://beebeep:qxJvsmXPzwNimv1T@cluster0.tomppyl.mongodb.net/?retryWrites=true&w=majority";
                var settings = MongoClientSettings.FromConnectionString(DbConnectionString);
                settings.ServerApi = new ServerApi(ServerApiVersion.V1);

                var mongoClient = new MongoClient(settings);
                Database = mongoClient.GetDatabase("SocialHelpApp");
                Console.WriteLine("Connected to MongoDB.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error connecting to MongoDB: {ex.Message}");
            }
        }

        public bool IsConnectionHealthy()
        {
            try
            {
                // Check if the connection is still active by sending a ping command
                var pingCommand = new BsonDocument("ping", 1);
                Database.RunCommand<BsonDocument>(pingCommand);
                Console.WriteLine("Connection is healthy.");
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Connection is not healthy: {ex.Message}");
                return false;
            }
        }

    }
}
