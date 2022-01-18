using MongoDB.Driver;
using MongoDB;

 string db_mongo_key = "mongodb://localhost:27017/?readPreference=primary&appname=MongoDB%20Compass&directConnection=true&ssl=false";
//string db_name = "MongoTest";
string db_name = "test1";

string db_collection = "test1";


    var client = new MongoClient(db_mongo_key);
    var db = client.GetDatabase(db_name);
    var collection = db.GetCollection<PersonModel>(db_collection);
var testdemo = new List<PersonModel>() {

                new PersonModel(){ id=1, Clinet="GT",Location="NY2",Area="EAST COAST" , Case="GTC-123451-1SA35D", Task="REPLACE HDD", Details="BROKEN HDD", Instruction="REMOVE OLD ADD NEW ONE TURN ONE THE SERVER", status="", Support="SUPPORT", Networking="JB", RemoteHand="B612", Date_Added=DateTime.Now, Data_work=DateTime.Parse("01/28/2022") },
                new PersonModel(){ id=2, Clinet="IAN", Location="NY4", Area="EAST COAST", Case="GTC-123451-1SA35D", Task="REPLACE HDD", Details="BROKEN HDD", Instruction="REMOVE OLD ADD NEW ONE TURN ONE THE SERVER", status="Tested", Support="SUPPORT", Networking="JB", RemoteHand="B612", Date_Added=DateTime.Parse("12/25/2017"), Data_work=DateTime.Parse("01/21/2022") },
                new PersonModel(){ id=3, Clinet="DCA", Location="DC3", Area="CHICAGO/AURORA", Case="GTC-123451-1SA35D", Task="REPLACE HDD", Details="BROKEN HDD", Instruction="REMOVE OLD ADD NEW ONE TURN ONE THE SERVER", status="Tested", Support="SUPPORT", Networking="JB", RemoteHand="B612", Date_Added=DateTime.Parse("12/25/2017"), Data_work=DateTime.Parse("01/21/2022") },
                new PersonModel(){ id=4, Clinet="6BOBO", Location="NY45", Area="EAST COAST", Case="GTC-123451-1SA35D", Task="REPLACE HDD", Details="BROKEN HDD", Instruction="REMOVE OLD ADD NEW ONE TURN ONE THE SERVER", status="??", Support="SUPPORT", Networking="JB", RemoteHand="B612", Date_Added=DateTime.Parse("12/25/2017"), Data_work=DateTime.Parse("01/21/2022") },
                new PersonModel(){ id=5, Clinet="GT",Location="NY2",Area="EAST COAST" , Case="GTC-123451-1SA35D", Task="REPLACE HDD", Details="BROKEN HDD", Instruction="REMOVE OLD ADD NEW ONE TURN ONE THE SERVER", status="", Support="SUPPORT", Networking="JB", RemoteHand="B612", Date_Added=DateTime.Now, Data_work=DateTime.Parse("01/28/2022") },
                new PersonModel(){ id=6, Clinet="GT",Location="NY2",Area="EAST COAST" , Case="GTC-123451-1SA35D", Task="REPLACE HDD", Details="BROKEN HDD", Instruction="REMOVE OLD ADD NEW ONE TURN ONE THE SERVER", status="", Support="SUPPORT", Networking="JB", RemoteHand="B612", Date_Added=DateTime.Now, Data_work=DateTime.Parse("01/28/2022") }

            };
//var persoin = new PersonModel { FirstName = "bobi", LastName = "olaf" };
await collection.InsertManyAsync(testdemo);
var person = await collection.FindAsync(_ => true);

foreach(var item in person.ToList())
{
    //Console.WriteLine($"{item.Id} { item.FirstName} {item.LastName}");    
    Console.WriteLine($"{item.id} { item.Case} {item.Area}");
}

Console.ReadLine();