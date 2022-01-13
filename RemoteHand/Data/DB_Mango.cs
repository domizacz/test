using MongoDB.Driver;

namespace RemoteHand.Data
{
    public class DB_Mango
    {
       
        string db_mongo_key = "mongodb://localhost:27017/?readPreference=primary&appname=MongoDB%20Compass&directConnection=true&ssl=false";
        var client = new MongoClient(db_mongo_key);
        var database = client.GetDatabase("test");
        var collection = database.GetCollection<ClassRH>("test");

        await collection.InsertManyAsync(temp.DemoRH());


    }
}
