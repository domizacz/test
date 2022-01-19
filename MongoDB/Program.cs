using MongoDB.Driver;
using MongoDB;

 string db_mongo_key = "mongodb://localhost:27017/?readPreference=primary&appname=MongoDB%20Compass&directConnection=true&ssl=false";
//string db_name = "MongoTest";
string db_name = "test";

string db_collection = "test";


    var client = new MongoClient(db_mongo_key);
    var db = client.GetDatabase(db_name);
    var collection = db.GetCollection<PersonModel>(db_collection);
//var testdemo = new List<PersonModel>() {

//                new PersonModel(){ id=1, Clinet="GT",Location="NY2",Area="EAST COAST" , Case="GTC-123451-1SA35D", Task="REPLACE HDD", Details="BROKEN HDD", Instruction="REMOVE OLD ADD NEW ONE TURN ONE THE SERVER", status="", Support="SUPPORT", Networking="JB", RemoteHand="B612", Date_Added=DateTime.Now, Data_work=DateTime.Parse("01/28/2022") },
//                new PersonModel(){ id=2, Clinet="IAN", Location="NY4", Area="EAST COAST", Case="GTC-123451-1SA35D", Task="REPLACE HDD", Details="BROKEN HDD", Instruction="REMOVE OLD ADD NEW ONE TURN ONE THE SERVER", status="Tested", Support="SUPPORT", Networking="JB", RemoteHand="B612", Date_Added=DateTime.Parse("12/25/2017"), Data_work=DateTime.Parse("01/21/2022") },
//                new PersonModel(){ id=3, Clinet="DCA", Location="DC3", Area="CHICAGO/AURORA", Case="GTC-123451-1SA35D", Task="REPLACE HDD", Details="BROKEN HDD", Instruction="REMOVE OLD ADD NEW ONE TURN ONE THE SERVER", status="Tested", Support="SUPPORT", Networking="JB", RemoteHand="B612", Date_Added=DateTime.Parse("12/25/2017"), Data_work=DateTime.Parse("01/21/2022") },
//                new PersonModel(){ id=4, Clinet="6BOBO", Location="NY45", Area="EAST COAST", Case="GTC-123451-1SA35D", Task="REPLACE HDD", Details="BROKEN HDD", Instruction="REMOVE OLD ADD NEW ONE TURN ONE THE SERVER", status="??", Support="SUPPORT", Networking="JB", RemoteHand="B612", Date_Added=DateTime.Parse("12/25/2017"), Data_work=DateTime.Parse("01/21/2022") },
//                new PersonModel(){ id=5, Clinet="GT",Location="NY2",Area="EAST COAST" , Case="GTC-123451-1SA35D", Task="REPLACE HDD", Details="BROKEN HDD", Instruction="REMOVE OLD ADD NEW ONE TURN ONE THE SERVER", status="", Support="SUPPORT", Networking="JB", RemoteHand="B612", Date_Added=DateTime.Now, Data_work=DateTime.Parse("01/28/2022") },
//                new PersonModel(){ id=6, Clinet="GT",Location="NY2",Area="EAST COAST" , Case="GTC-123451-1SA35D", Task="REPLACE HDD", Details="BROKEN HDD", Instruction="REMOVE OLD ADD NEW ONE TURN ONE THE SERVER", status="", Support="SUPPORT", Networking="JB", RemoteHand="B612", Date_Added=DateTime.Now, Data_work=DateTime.Parse("01/28/2022") }

//            };
Random random = new Random();   
int dayrondom = random.Next(1, 28);
int munthrandom =random.Next(1, 12);
int i = 15;
//var testdemo = new List<PersonModel>() {

//                new PersonModel(){ id=1, Clinet="GT",Location="NY2",Area="EAST COAST" , Case="GTC-123451-1SA35D", Task="REPLACE HDD", Details="BROKEN HDD", Instruction="REMOVE OLD ADD NEW ONE TURN ONE THE SERVER", status="", Support="SUPPORT", Networking="JB", RemoteHand="B612", Date_Added=DateTime.Now, Data_work=DateTime.Parse("01/28/2022") },
//                new PersonModel(){ id=2, Clinet="IAN", Location="NY4", Area="EAST COAST", Case="GTC-123451-1SA35D", Task="REPLACE HDD", Details="BROKEN HDD", Instruction="REMOVE OLD ADD NEW ONE TURN ONE THE SERVER", status="Tested", Support="SUPPORT", Networking="JB", RemoteHand="B612", Date_Added=DateTime.Parse("12/25/2017"), Data_work=DateTime.Parse("01/21/2022") },
//                new PersonModel(){ id=3, Clinet="DCA", Location="DC3", Area="CHICAGO/AURORA", Case="GTC-123451-1SA35D", Task="REPLACE HDD", Details="BROKEN HDD", Instruction="REMOVE OLD ADD NEW ONE TURN ONE THE SERVER", status="Tested", Support="SUPPORT", Networking="JB", RemoteHand="B612", Date_Added=DateTime.Parse("12/25/2017"), Data_work=DateTime.Parse("01/21/2022") },
//                new PersonModel(){ id=4, Clinet="6BOBO", Location="NY45", Area="EAST COAST", Case="GTC-123451-1SA35D", Task="REPLACE HDD", Details="BROKEN HDD", Instruction="REMOVE OLD ADD NEW ONE TURN ONE THE SERVER", status="??", Support="SUPPORT", Networking="JB", RemoteHand="B612", Date_Added=DateTime.Parse("12/25/2017"), Data_work=DateTime.Parse("01/21/2022") },
//                new PersonModel(){ id=5, Clinet="GT",Location="NY2",Area="EAST COAST" , Case="GTC-123451-1SA35D", Task="REPLACE HDD", Details="BROKEN HDD", Instruction="REMOVE OLD ADD NEW ONE TURN ONE THE SERVER", status="", Support="SUPPORT", Networking="JB", RemoteHand="B612", Date_Added=DateTime.Now, Data_work=DateTime.Parse("01/28/2022") },
//                new PersonModel(){ id=6, Clinet="GT",Location="NY2",Area="EAST COAST" , Case="GTC-123451-1SA35D", Task="REPLACE HDD", Details="BROKEN HDD", Instruction="REMOVE OLD ADD NEW ONE TURN ONE THE SERVER", status="", Support="SUPPORT", Networking="JB", RemoteHand="B612", Date_Added=DateTime.Now, Data_work=DateTime.Parse("01/28/2022") }

//            };
var testdemo = new List<PersonModel>();

while (i < 10000)
{
    testdemo.Add(new PersonModel { id = i, Clinet = "GT", Location = "NY4", Area = "test", Case = "GTC-1111-111", Task = "Remove HDD", Details = "BROKEN HDD", Instruction = "REMOVE OLD ADD NEW ONE TURN ONE THE SERVER", status = "", Support = "SUPPORT", Networking = "JB", RemoteHand = "B11", Date_Added = DateTime.Now, Data_work = DateTime.Parse(random.Next(1, 12) + "/" + random.Next(1, 24) + "/2022") });    
    
    i++;
 }

while (i < 20000)
{
    testdemo.Add(new PersonModel { id = i, Clinet = "GT", Location = "DC3", Area = "CHICAGO/AURORA", Case = "GTC-122-111", Task = "Err2or", Details = "BROKEN HDD", Instruction = "REMOVE OLD ADD NEW ONE TURN ONE THE SERVER", status = "", Support = "SUPPORT", Networking = "J", RemoteHand = "B12", Date_Added = DateTime.Now, Data_work = DateTime.Parse(random.Next(1, 12) + "/" + random.Next(1, 24) + "/2022") });

    i++;
}
while (i < 30000)
{
    testdemo.Add(new PersonModel { id = i, Clinet = "GT", Location = "NY4", Area = "EAST COAST", Case = "GTC-122-1141", Task = "Error", Details = "BROKEN HDD", Instruction = "REMOVE OLD ADD NEW ONE TURN ONE THE SERVER", status = "", Support = "SUPPORT", Networking = "BB", RemoteHand = "B2", Date_Added = DateTime.Now, Data_work = DateTime.Parse(random.Next(1, 12) + "/" + random.Next(1, 24) + "/2022") });

    i++;
}
while (i < 40000)
{
    testdemo.Add(new PersonModel { id = i, Clinet = "GT", Location = "JPX", Area = "ASIA/PACIFIC", Case = "GTC-122-1141", Task = "Error", Details = "BROKEN HDD", Instruction = "REMOVE OLD ADD NEW ONE TURN ONE THE SERVER", status = "", Support = "SUPPORT", Networking = "BB", RemoteHand = "B2", Date_Added = DateTime.Now, Data_work = DateTime.Parse(random.Next(1, 12) + "/" + random.Next(1, 24) + "/2022") });

    i++;
}
while (i < 50000)
{
    testdemo.Add(new PersonModel { id = i, Clinet = "GT", Location = "TOR", Area = "CANADA", Case = "GTC-122-1141", Task = "Error", Details = "BROKEN HDD", Instruction = "REMOVE OLD ADD NEW ONE TURN ONE THE SERVER", status = "", Support = "PAT", Networking = "DOM", RemoteHand = "YOU", Date_Added = DateTime.Now, Data_work = DateTime.Parse(random.Next(1, 12) + "/" + random.Next(1, 24) + "/2022") });

    i++;
}


//var persoin = new PersonModel { FirstName = "bobi", LastName = "olaf" };

await collection.InsertManyAsync(testdemo);
var person = await collection.FindAsync(_ => true);

foreach(var item in person.ToList())
{
    //Console.WriteLine($"{item.Id} { item.FirstName} {item.LastName}");    
    Console.WriteLine($"{item.id} { item.Data_work} {item.Area}");
}

Console.ReadLine();