using System;
using System.Collections;
using System.Collections.Generic;
using MongoDB.Driver;
using MongoDB.Bson;
using System.Threading.Tasks;
using System.IO;
using System.Linq;
using Newtonsoft.Json;

namespace ProjectRandom.Models
{
    public class MongoConnection
    {
        private static MongoConnection InstanceConnection { get; set; } = null;
        private static IMongoDatabase Database { get; set; } = null;

        private MongoConnection()
        {
            // ToDo: Rewrite code in smaller way
            var creditsFile = File.ReadAllText(@"./credits.json");
            //Console.WriteLine(creditsFile);
            Dictionary<string, string> credits = JsonConvert.DeserializeObject<Dictionary<string, string>>(creditsFile);
            var res = credits.Values.ToList();
            string connectionString =
                $"mongodb://{credits["user"]}:{credits["password"]}@{credits["host"]}:{credits["port"]}/?authMecanism=DEFAULT&authSource={credits["db"]}";
            MongoClient client = new MongoClient(connectionString);
            Database = client.GetDatabase(credits["db"]);
            //Console.WriteLine(database.ListCollections().ToList().ToJson());
        }

        //private static async Task GetDatabaseNames(MongoClient client)
        //{
        //    using (var cursor = await GetDatabase().)
        //    {
        //        var databaseDocuments = await cursor.ToListAsync();
        //        foreach (var databaseDocument in databaseDocuments)
        //        {
        //            Console.WriteLine(databaseDocument["name"]);
        //        }
        //    }
        //}

        public IMongoDatabase GetDatabase()
        {
            return Database;
        }

        public static MongoConnection GetInstance()
        {
            if (Database == null || InstanceConnection == null)
                InstanceConnection = new MongoConnection();

            return InstanceConnection;
        }
    }
}