using MongoDB.Driver;
using RemoteHand.Data;
using Microsoft.Extensions.Configuration;
using MongoDB.Bson;

namespace RemoteHand.Data
{
    public interface IDB_Mango
    {
        void testclass();
    }

    public class DB_Mango : IDB_Mango
    {
        private readonly IConfiguration _config;

        public DB_Mango(IConfiguration config)
        {
            _config = config;
        }

        private const string db_mongo_key = "mongodb://localhost:27017/?readPreference=primary&appname=MongoDB%20Compass&directConnection=true&ssl=false";
        private const string db_name = "test";
        private const string db_collection = "test";

        private IMongoCollection<T> ConnectionToMongo<T> (in string collection)
        {
            var client = new MongoClient(db_mongo_key);
            var db = client.GetDatabase(db_name);
            return db.GetCollection<T>(collection);
        }

        public  List<ClassRH> Getallrecord()
        {
            var record = ConnectionToMongo<ClassRH>(db_collection);
            var results = record.Find(_ => true);
                return results.ToList();

        }








        public void testclass()
        {
            Demo temp = new Demo();
            
            var db_mongo_key = _config.GetValue<string>("MangoDBconnection:connection");
            var db_name = _config.GetValue<string>("MangoDBconnection:DB");
            var db_collection = _config.GetValue<string>("MangoDBconnection:Collection");
            var client = new MongoClient(db_mongo_key);
            var database = client.GetDatabase(db_name);
            var collection = database.GetCollection<ClassRH>(db_collection);

            collection.InsertManyAsync(temp.DemoRH());
        }

       

    }
}
