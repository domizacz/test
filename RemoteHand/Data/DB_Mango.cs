using MongoDB.Driver;
using RemoteHand.Data;
using Microsoft.Extensions.Configuration;
using MongoDB.Bson;
using RemoteHand.Pages;

namespace RemoteHand.Data
{
   

    public class DB_Mango 
    {
        private readonly IConfiguration _config;

        public DB_Mango(IConfiguration config)
        {
            _config = config;
        }

        private const string db_mongo_key = "mongodb+srv://test:G9z7P5JKnR18@rht0.uynmj.mongodb.net/myFirstDatabase?retryWrites=true&w=majority";
        private const string db_name = "test";
        private const string db_collection = "test";

        private IMongoCollection<T> ConnectionToMongo<T> (in string collection)
        {
            var client = new MongoClient(db_mongo_key);
            var db = client.GetDatabase(db_name);
            return db.GetCollection<T>(collection);
        }

        public  List<ClassRH> Getallrecord(DateTime friday)
        {
            var Connection = ConnectionToMongo<ClassRH>(db_collection);
           var request = new BsonDocument("Data_work", new DateTime(friday.Year, friday.Month, friday.Day));
            var results = Connection.Find(request);
            var sortre = new BsonDocument("Area", 1);
           var sort = results.Sort(sortre);

            return sort.ToList();
            
        }


        public void AddToDB(ClassRH AddRecord)
        {
            var Connection = ConnectionToMongo<ClassRH>(db_collection);
            Connection.InsertOne(AddRecord);
        }

        public void EditDB(ClassRH edit)
        {
            var Connection = ConnectionToMongo<ClassRH>(db_collection);

            Connection.ReplaceOne(Builders<ClassRH>.Filter.Eq(i => i.id, edit.id), edit);
            
        }
        public void delDB(int i)
        {
            var Connection = ConnectionToMongo<ClassRH>(db_collection);

            Connection.DeleteOne(Builders<ClassRH>.Filter.Eq(t => t.id, i));
            
        }

        public int nextrecord()
        {
            var Connection = ConnectionToMongo<ClassRH>(db_collection);
            var emptyFilter = Builders<ClassRH>.Filter.Empty;
            var check = Connection.Find(emptyFilter).Count();
            if (check == 0)
            {
                return 0;
            }
            var howmany = Connection.AsQueryable().OrderByDescending(c => c.id).First();
            return howmany.id;

        }

        public void UpdateStatus(int id, string Name)
        {
            var Connection = ConnectionToMongo<ClassRH>(db_collection);
            Connection.UpdateOne(Builders<ClassRH>.Filter.Eq(i => i.id, id), Builders<ClassRH>.Update.Set(n => n.status, Name));


        }

        //public void testclass()
        //{
        //    Demo temp = new Demo();

        //    var db_mongo_key = _config.GetValue<string>("MangoDBconnection:connection");
        //    var db_name = _config.GetValue<string>("MangoDBconnection:DB");
        //    var db_collection = _config.GetValue<string>("MangoDBconnection:Collection");
        //    var client = new MongoClient(db_mongo_key);
        //    var database = client.GetDatabase(db_name);
        //    var collection = database.GetCollection<ClassRH>(db_collection);

        //    collection.InsertManyAsync(temp.DemoRH());
        //}



    }
}
