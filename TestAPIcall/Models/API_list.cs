namespace TestAPIcall.Models
{
    public class APIGet
    {
        
        public int count { get; set; }
        public List<API_list> entries { get; set; }
    }
    public class API_list
    {

        public string API { get; set; }
        public string Description { get; set; }
        public string Auth { get; set; } = "null";
        public bool HTTPS { get; set; }
        public string Cors { get; set; }
        public string Link { get; set; }
        public string Category { get; set; }
    }
  
   
}
