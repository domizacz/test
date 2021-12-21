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
<<<<<<< HEAD
                new ClassRH(){ id=1, Clinet="GT",Location="NY2",Area="EAST COAST" , Case="GTC-123451-1SA35D", Task="REPLACE HDD", Details="BROKEN HDD", Instruction="REMOVE OLD ADD NEW ONE TURN ONE THE SERVER", status="", Support="SUPPORT", Networking="JB", RemoteHand="B612", Date_Added=DateTime.Parse("10/15/2017"), Data_work=DateOnly.ParseExact("12/31/2021" , "MM/dd/yyyy") },
                new ClassRH(){ id=2, Clinet="IAN", Location="NY4", Area="EAST COAST", Case="GTC-123451-1SA35D", Task="REPLACE HDD", Details="BROKEN HDD", Instruction="REMOVE OLD ADD NEW ONE TURN ONE THE SERVER", status="Tested", Support="SUPPORT", Networking="JB", RemoteHand="B612", Date_Added=DateTime.Parse("12/25/2017"), Data_work=DateOnly.ParseExact("12/24/2021" , "MM/dd/yyyy") },
                new ClassRH(){ id=2, Clinet="DCA", Location="DC3", Area="CHICAGO/AURORA", Case="GTC-123451-1SA35D", Task="REPLACE HDD", Details="BROKEN HDD", Instruction="REMOVE OLD ADD NEW ONE TURN ONE THE SERVER", status="Tested", Support="SUPPORT", Networking="JB", RemoteHand="B612", Date_Added=DateTime.Parse("12/25/2017"), Data_work=DateOnly.ParseExact("12/24/2021" , "MM/dd/yyyy") },
                new ClassRH(){ id=2, Clinet="DC", Location="DC2", Area="CHICAGO/AURORA", Case="GTC-12584-1SA35D", Task="Fantray reporting failed ", Details="BROKEN HDD", Instruction="REMOVE OLD ADD NEW ONE TURN ONE THE SERVER", status="Tested", Support="SUPPORT", Networking="JB", RemoteHand="B612", Date_Added=DateTime.Parse("12/25/2017"), Data_work=DateOnly.ParseExact("12/24/2021" , "MM/dd/yyyy") },
=======
<<<<<<< HEAD
                new ClassRH(){ id=1, Clinet="GT",Location="NY4",Area="test" , Case="GTC-123451-1SA35D", Task="REPLACE HDD", Details="BROKEN HDD", Instruction="REMOVE OLD ADD NEW ONE TURN ONE THE SERVER", status="", Support="SUPPORT", Networking="JB", RemoteHand="B612", Date_Added=DateTime.Parse("10/15/2017"), Data_work=DateOnly.ParseExact("12/10/2017" , "MM/dd/yyyy") },
                new ClassRH(){ id=2, Clinet="GT", Location="NY4", Area="test", Case="GTC-123451-1SA35D", Task="REPLACE HDD", Details="BROKEN HDD", Instruction="REMOVE OLD ADD NEW ONE TURN ONE THE SERVER", status="Tested", Support="SUPPORT", Networking="JB", RemoteHand="B612", Date_Added=DateTime.Parse("12/25/2017"), Data_work=DateOnly.ParseExact("12/15/2022" , "MM/dd/yyyy") },
                new ClassRH(){ id=2, Clinet="BOBO", Location="NY4", Area="EAST COAST", Case="GTC-123451-1SA35D", Task="REPLACE HDD", Details="BROKEN HDD", Instruction="REMOVE OLD ADD NEW ONE TURN ONE THE SERVER", status="??", Support="SUPPORT", Networking="JB", RemoteHand="B612", Date_Added=DateTime.Parse("12/25/2017"), Data_work=DateOnly.ParseExact("12/15/2022" , "MM/dd/yyyy") },
                new ClassRH(){ id=1, Clinet="GT",Location="dc3",Area="chicago" , Case="GTC-123451-1SA35D", Task="REPLACE HDD", Details="BROKEN HDD", Instruction="REMOVE OLD ADD NEW ONE TURN ONE THE SERVER", status="", Support="SUPPORT", Networking="JB", RemoteHand="B612", Date_Added=DateTime.Parse("10/15/2017"), Data_work=DateOnly.ParseExact("12/10/2017" , "MM/dd/yyyy") },
                new ClassRH(){ id=2, Clinet="GT", Location="dc3", Area="chicago", Case="GTC-123451-1SA35D", Task="REPLACE HDD", Details="BROKEN HDD", Instruction="REMOVE OLD ADD NEW ONE TURN ONE THE SERVER", status="Tested", Support="SUPPORT", Networking="JB", RemoteHand="B612", Date_Added=DateTime.Parse("12/25/2017"), Data_work=DateOnly.ParseExact("12/15/2022" , "MM/dd/yyyy") },
                new ClassRH(){ id=2, Clinet="BOBO", Location="ch1", Area="chic", Case="GTC-123451-1SA35D", Task="REPLACE HDD", Details="BROKEN HDD", Instruction="REMOVE OLD ADD NEW ONE TURN ONE THE SERVER", status="??", Support="SUPPORT", Networking="JB", RemoteHand="B612", Date_Added=DateTime.Parse("12/25/2017"), Data_work=DateOnly.ParseExact("12/15/2022" , "MM/dd/yyyy") },
                new ClassRH(){ id=2, Clinet="GT", Location="NY4", Area="test", Case="GTC-123451-1SA35D", Task="REPLACE HDD", Details="BROKEN HDD", Instruction="REMOVE OLD ADD NEW ONE TURN ONE THE SERVER", status="Tested", Support="SUPPORT", Networking="JB", RemoteHand="B612", Date_Added=DateTime.Parse("12/25/2017"), Data_work=DateOnly.ParseExact("12/15/2022" , "MM/dd/yyyy") }


=======
                new ClassRH(){ id=1, Clinet="GT",Location="NY2",Area="EAST COAST" , Case="GTC-123451-1SA35D", Task="REPLACE HDD", Details="BROKEN HDD", Instruction="REMOVE OLD ADD NEW ONE TURN ONE THE SERVER", status="", Support="SUPPORT", Networking="JB", RemoteHand="B612", Date_Added=DateTime.Parse("10/15/2017"), Data_work=DateOnly.ParseExact("12/24/2017" , "MM/dd/yyyy") },
                new ClassRH(){ id=2, Clinet="IAN", Location="NY4", Area="EAST COAST", Case="GTC-123451-1SA35D", Task="REPLACE HDD", Details="BROKEN HDD", Instruction="REMOVE OLD ADD NEW ONE TURN ONE THE SERVER", status="Tested", Support="SUPPORT", Networking="JB", RemoteHand="B612", Date_Added=DateTime.Parse("12/25/2017"), Data_work=DateOnly.ParseExact("12/24/2022" , "MM/dd/yyyy") },
                new ClassRH(){ id=2, Clinet="DCA", Location="DC3", Area="CHICAGO/AURORA", Case="GTC-123451-1SA35D", Task="REPLACE HDD", Details="BROKEN HDD", Instruction="REMOVE OLD ADD NEW ONE TURN ONE THE SERVER", status="Tested", Support="SUPPORT", Networking="JB", RemoteHand="B612", Date_Added=DateTime.Parse("12/25/2017"), Data_work=DateOnly.ParseExact("12/24/2022" , "MM/dd/yyyy") },
                new ClassRH(){ id=2, Clinet="DC", Location="DC2", Area="CHICAGO/AURORA", Case="GTC-12584-1SA35D", Task="Fantray reporting failed ", Details="BROKEN HDD", Instruction="REMOVE OLD ADD NEW ONE TURN ONE THE SERVER", status="Tested", Support="SUPPORT", Networking="JB", RemoteHand="B612", Date_Added=DateTime.Parse("12/25/2017"), Data_work=DateOnly.ParseExact("12/24/2022" , "MM/dd/yyyy") },
>>>>>>> 06467c7c57e53d4d2248de9c2e5c896ef5396afc

                new ClassRH(){ id=2, Clinet="3BOBO", Location="NY4", Area="EAST COAST", Case="GTC-123451-1SA35D", Task="REPLACE HDD", Details="BROKEN HDD", Instruction="REMOVE OLD ADD NEW ONE TURN ONE THE SERVER", status="??", Support="SUPPORT", Networking="JB", RemoteHand="B612", Date_Added=DateTime.Parse("12/25/2017"), Data_work=DateOnly.ParseExact("12/15/2021" , "MM/dd/yyyy") },
                new ClassRH(){ id=1, Clinet="4GT",Location="bas",Area="EUROPE" , Case="GTC-123451-1SA35D", Task="REPLACE HDD", Details="BROKEN HDD", Instruction="REMOVE OLD ADD NEW ONE TURN ONE THE SERVER", status="", Support="SUPPORT", Networking="JB", RemoteHand="B612", Date_Added=DateTime.Parse("10/15/2017"), Data_work=DateOnly.ParseExact("12/10/2017" , "MM/dd/yyyy") },
<<<<<<< HEAD
                new ClassRH(){ id=2, Clinet="5GT", Location="fr2", Area="EUROPE", Case="GTC-123451-1SA35D", Task="REPLACE HDD", Details="BROKEN HDD", Instruction="REMOVE OLD ADD NEW ONE TURN ONE THE SERVER", status="Tested", Support="SUPPORT", Networking="JB", RemoteHand="B612", Date_Added=DateTime.Parse("12/24/2022"), Data_work=DateOnly.ParseExact("12/24/2021" , "MM/dd/yyyy") },
                new ClassRH(){ id=2, Clinet="6BOBO", Location="NY45", Area="EAST COAST", Case="GTC-123451-1SA35D", Task="REPLACE HDD", Details="BROKEN HDD", Instruction="REMOVE OLD ADD NEW ONE TURN ONE THE SERVER", status="??", Support="SUPPORT", Networking="JB", RemoteHand="B612", Date_Added=DateTime.Parse("12/25/2017"), Data_work=DateOnly.ParseExact("12/31/2021" , "MM/dd/yyyy") }
=======
                new ClassRH(){ id=2, Clinet="5GT", Location="fr2", Area="EUROPE", Case="GTC-123451-1SA35D", Task="REPLACE HDD", Details="BROKEN HDD", Instruction="REMOVE OLD ADD NEW ONE TURN ONE THE SERVER", status="Tested", Support="SUPPORT", Networking="JB", RemoteHand="B612", Date_Added=DateTime.Parse("12/25/2017"), Data_work=DateOnly.ParseExact("12/24/2022" , "MM/dd/yyyy") },
                new ClassRH(){ id=2, Clinet="6BOBO", Location="NY45", Area="EAST COAST", Case="GTC-123451-1SA35D", Task="REPLACE HDD", Details="BROKEN HDD", Instruction="REMOVE OLD ADD NEW ONE TURN ONE THE SERVER", status="??", Support="SUPPORT", Networking="JB", RemoteHand="B612", Date_Added=DateTime.Parse("12/25/2017"), Data_work=DateOnly.ParseExact("12/15/2022" , "MM/dd/yyyy") }
>>>>>>> cfba031a8d8f68ceeab6adbd74c7419d91b65a24
>>>>>>> 06467c7c57e53d4d2248de9c2e5c896ef5396afc
            };      

            return testdemo;
        }

    }
        
 }

      

            //1, "NY4", "GT", "GTS-1253-1533", "Reprace HDD", "remove trase - add more hdd", "wait", "Tested", "??", "JP", "AP", "John", "1/1/1991", "12/12/2021"

            //{ 1,'ny4', "GT", "GTS-1253-1533", "Reprace HDD", "remove trase - add more hdd", "wait", "Tested", "JP", "AP", "John", 1 / 1 / 2021, 12 / 17 / 21 } 
        
    

    
   


