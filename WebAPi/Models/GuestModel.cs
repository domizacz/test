using System.Collections.Generic;

namespace WebAPi.Models
{
    public class GuestModel
    {
       public int Id { get; set; }
        public string FirstName { get; set; }

        public string LastName { get; set; }
 
        public List <Guest> Room { get; set; }
    }
    public class Guest
    {
        public string size { get; set; }
        public int day { get; set; }
    }
}
