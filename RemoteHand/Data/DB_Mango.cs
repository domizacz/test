﻿using MongoDB.Driver;
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

        private const string db_mongo_key = "mongodb://localhost:27017/?readPreference=primary&appname=MongoDB%20Compass&directConnection=true&ssl=false";
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
            var record = ConnectionToMongo<ClassRH>(db_collection);
           var request = new BsonDocument("Data_work", new DateTime(friday.Year, friday.Month, friday.Day));
            var results = record.Find(request);
            var sortre = new BsonDocument("Area", 1);
           var sort = results.Sort(sortre);

            return sort.ToList();
            
        }


        public void AddToDB(ClassRH AddRecord)
        {
            var record = ConnectionToMongo<ClassRH>(db_collection);
            record.InsertOne(AddRecord);
        }

        public void EditDB(ClassRH edit)
        {
            var record = ConnectionToMongo<ClassRH>(db_collection);

            record.ReplaceOne(Builders<ClassRH>.Filter.Eq(i => i.id, edit.id), edit);
            
        }
        public void delDB(int i)
        {
            var record = ConnectionToMongo<ClassRH>(db_collection);

            record.DeleteOne(Builders<ClassRH>.Filter.Eq(t => t.id, i));
            
        }

        public int nextrecord()
        {
            var record = ConnectionToMongo<ClassRH>(db_collection);
            var emptyFilter = Builders<ClassRH>.Filter.Empty;
            var check = record.Find(emptyFilter).Count();
            if (check == 0)
            {
                return 0;
            }
            var howmany = record.AsQueryable().OrderByDescending(c => c.id).First();
            return howmany.id;

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
