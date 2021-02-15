using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NBA
{
    public class MongoCRUD
    {
        private static IMongoDatabase db;
        public static IMongoDatabase GetDB()
        {
            if (db == null)
            {
                var client = new MongoClient();
                db = client.GetDatabase("NBA");
            }
            return db;
        }
        public static void Create<T>(string colName, T data)
        {
            var collection = db.GetCollection<T>(colName);
            collection.InsertOne(data);
        }
    }
}
