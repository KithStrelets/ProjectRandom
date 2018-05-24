using System;
using System.Collections;
using System.Collections.Generic;
using MongoDB.Driver;
using MongoDB.Bson;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;
using ProjectRandom.Models.Plots;

namespace ProjectRandom.Models.Database
{
    public class MongoConnection : IDatabaseConnection
    {
        private static MongoConnection InstanceConnection { get; set; } = null;

        private static IMongoDatabase Database { get; set; } = null;

        // ToDo: password --> char[] --> argon
        private MongoConnection()
        {
            Dictionary<string, string> credits = JsonConvert.DeserializeObject<Dictionary<string, string>>(File.ReadAllText(@"./credits.json"));
            string connectionString =
                $"mongodb://{credits["user"]}:{credits["password"]}@{credits["host"]}:{credits["port"]}/?authMecanism=DEFAULT&authSource={credits["db"]}";
            Database = new MongoClient(connectionString).GetDatabase(credits["db"]);
        }

        //private static async Task GetDatabaseNames(MongoClient client)
        //{
        //    using (var cursor = await GetDatabase())
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
            try
            {
                if (Database == null || InstanceConnection == null)
                {
                    InstanceConnection = new MongoConnection();
                }
            }
            catch
            {
                // ToDo: Add handler of null receiver on the web-page like "Sorry, we are fixing the connection"
                return null;
            }

            return InstanceConnection;
        }

        public string GetAllSessions()
        {
            // ToDo: Complete implementation and rewrite into async task
            return "Array<Session>";
        }

        public string GetSession(object identificator)
        {
            // ToDo: Complete implementation and rewrite into async task
            return "Object<Session>";
        }

        public string GetRandomItem(object collection)
        {
            // ToDo: Complete implementation and rewrite into async task
            return "Object<Item>";
        }

        public string GetRandomBuff(object type)
        {
            // ToDo: Complete implementation and rewrite into async task
            return "Object<Buff>";
        }

        public string GetRandomSkill(object characteristic)
        {
            // ToDo: Complete implementation and rewrite into async task
            return "Object<Skill>";
        }

        public Race GetRandomRace()
        {
            // ToDo: Complete implementation and rewrite into async task
            //       And think about memory costs of such return
            return new Race();
        }
    }
}