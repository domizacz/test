using MongoDB.Driver;
using RemoteHand.Data;
using Microsoft.Extensions.Configuration;

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
