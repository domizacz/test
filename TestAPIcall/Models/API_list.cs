namespace TestAPIcall.Models
{
    public class APIGet
    {
        
        public int Count { get; set; }
        //public List<API_list> Entries { get; set; }
    }
    public class API_list
    {

        public string API { get; set; }
        public string Description { get; set; }
        public string Auth { get; set; } = "null";
        public bool Https { get; set; }
        public string Cors { get; set; }
        public string Link { get; set; }
        public string Category { get; set; }
    }
  
   
}
