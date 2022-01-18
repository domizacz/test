
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace MongoDB;

public class PersonModel
{
    //[BsonId]
    //[BsonRepresentation(BsonType.ObjectId)]
    //public string Id { get; set; }
    //public string FirstName { get; set; }

    //public string LastName { get; set; }

   
        public int id { get; set; }
        public string Location { get; set; }
        public string Area { get; set; }
        public string Clinet { get; set; }
        public string Case { get; set; }
        public string Task { get; set; }
        public string Details { get; set; }
        public string Instruction { get; set; }
        public string status { get; set; }
        public string tested { get; set; }
        public string Support { get; set; }
        public string Networking { get; set; }
        public string RemoteHand { get; set; }
        public DateTime Date_Added { get; set; }
        public DateTime Data_work { get; set; }

        public string user { get; set; }
    }
