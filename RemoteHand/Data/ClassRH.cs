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



        

    }
    public class Demo
    {
        public List<ClassRH> DemoRH()
        {

            var testdemo = new List<ClassRH>() {
                new ClassRH(){ id=1, Clinet="GT",Location="NY4",Area="test" , Case="GTC-123451-1SA35D", Task="REPLACE HDD", Details="BROKEN HDD", Instruction="REMOVE OLD ADD NEW ONE TURN ONE THE SERVER", status="", Support="SUPPORT", Networking="JB", RemoteHand="B612", Date_Added=DateTime.Parse("10/15/2017"), Data_work=DateOnly.ParseExact("12/10/2017" , "MM/dd/yyyy") },
                new ClassRH(){ id=2, Clinet="GT", Location="NY4", Area="test", Case="GTC-123451-1SA35D", Task="REPLACE HDD", Details="BROKEN HDD", Instruction="REMOVE OLD ADD NEW ONE TURN ONE THE SERVER", status="Tested", Support="SUPPORT", Networking="JB", RemoteHand="B612", Date_Added=DateTime.Parse("12/25/2017"), Data_work=DateOnly.ParseExact("12/15/2022" , "MM/dd/yyyy") },
                new ClassRH(){ id=2, Clinet="BOBO", Location="NY4", Area="EAST COAST", Case="GTC-123451-1SA35D", Task="REPLACE HDD", Details="BROKEN HDD", Instruction="REMOVE OLD ADD NEW ONE TURN ONE THE SERVER", status="??", Support="SUPPORT", Networking="JB", RemoteHand="B612", Date_Added=DateTime.Parse("12/25/2017"), Data_work=DateOnly.ParseExact("12/15/2022" , "MM/dd/yyyy") }
            };      

            return testdemo;
        }

    }
        
 }

      

            //1, "NY4", "GT", "GTS-1253-1533", "Reprace HDD", "remove trase - add more hdd", "wait", "Tested", "??", "JP", "AP", "John", "1/1/1991", "12/12/2021"

            //{ 1,'ny4', "GT", "GTS-1253-1533", "Reprace HDD", "remove trase - add more hdd", "wait", "Tested", "JP", "AP", "John", 1 / 1 / 2021, 12 / 17 / 21 } 
        
    

    
   


