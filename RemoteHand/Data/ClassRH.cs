namespace RemoteHand.Data
{
    public class ClassRH
    {
       public int id { get; set; }
       public string Location { get; set; }
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
       public DateOnly Date_Added { get; set; }
       public DateTime Data_work { get; set; }



        

    }
    public class Demo
    {
        public List<ClassRH> DemoList()
        {

            var testdemo = new List<ClassRH>() {
                new ClassRH(){ id=1, Location="NY4", Case="GTC-123451-1SA35D", Task="REPLACE HDD", Details="BROKEN HDD", Instruction="REMOVE OLD ADD NEW ONE TURN ONE THE SERVER", status="PENDING", Support="TEST SUPPORT", Networking="JB", RemoteHand="B612" },
                new ClassRH(){ id=2, Location="NY4", Case="GTC-123451-1SA35D", Task="REPLACE HDD", Details="BROKEN HDD", Instruction="REMOVE OLD ADD NEW ONE TURN ONE THE SERVER", status="PENDING", Support="TEST SUPPORT", Networking="JB", RemoteHand="B612" }
        };

            return testdemo;
        }

    }
        
 }

      

            //1, "NY4", "GT", "GTS-1253-1533", "Reprace HDD", "remove trase - add more hdd", "wait", "Tested", "??", "JP", "AP", "John", "1/1/1991", "12/12/2021"

            //{ 1,'ny4', "GT", "GTS-1253-1533", "Reprace HDD", "remove trase - add more hdd", "wait", "Tested", "JP", "AP", "John", 1 / 1 / 2021, 12 / 17 / 21 } 
        
    

    
   


