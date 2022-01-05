namespace RemoteHand.Data
{
    public class ClassRH
    {
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
        public DateOnly Data_work { get; set; }

        public string user { get; set; }





    }
   

    public class Demo
    {
        public List<ClassRH> DemoRH()
        {

            var testdemo = new List<ClassRH>() {

                new ClassRH(){ id=1, Clinet="GT",Location="NY2",Area="EAST COAST" , Case="GTC-123451-1SA35D", Task="REPLACE HDD", Details="BROKEN HDD", Instruction="REMOVE OLD ADD NEW ONE TURN ONE THE SERVER", status="", Support="SUPPORT", Networking="JB", RemoteHand="B612", Date_Added=DateTime.Now, Data_work=DateOnly.ParseExact("01/07/2022" , "MM/dd/yyyy") },
                new ClassRH(){ id=2, Clinet="IAN", Location="NY4", Area="EAST COAST", Case="GTC-123451-1SA35D", Task="REPLACE HDD", Details="BROKEN HDD", Instruction="REMOVE OLD ADD NEW ONE TURN ONE THE SERVER", status="Tested", Support="SUPPORT", Networking="JB", RemoteHand="B612", Date_Added=DateTime.Parse("12/25/2017"), Data_work=DateOnly.ParseExact("01/07/2022" , "MM/dd/yyyy") },
                new ClassRH(){ id=3, Clinet="DCA", Location="DC3", Area="CHICAGO/AURORA", Case="GTC-123451-1SA35D", Task="REPLACE HDD", Details="BROKEN HDD", Instruction="REMOVE OLD ADD NEW ONE TURN ONE THE SERVER", status="Tested", Support="SUPPORT", Networking="JB", RemoteHand="B612", Date_Added=DateTime.Parse("12/25/2017"), Data_work=DateOnly.ParseExact("01/07/2022" , "MM/dd/yyyy") },
                new ClassRH(){ id=4, Clinet="6BOBO", Location="NY45", Area="EAST COAST", Case="GTC-123451-1SA35D", Task="REPLACE HDD", Details="BROKEN HDD", Instruction="REMOVE OLD ADD NEW ONE TURN ONE THE SERVER", status="??", Support="SUPPORT", Networking="JB", RemoteHand="B612", Date_Added=DateTime.Parse("12/25/2017"), Data_work=DateOnly.ParseExact("01/07/2022" , "MM/dd/yyyy") }

            };

            return testdemo;
        }

    }

}






