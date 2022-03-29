namespace CallR.Models
{
    public class APIList
    {
        public int Count { get; set; }
        public List<APIs> Entries { get; set; }
    }
    public class APIs
    {
        public string API {set; get; }
        public string Description { set; get; }
        public string Auth { set; get; } = "none";
        public bool Https { set; get; }
        public string Cors { set; get; }
        public string Link { get; set; }
        public string Category { get; set; }
    }
}
