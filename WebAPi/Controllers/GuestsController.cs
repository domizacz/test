using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using WebAPi.Models;

namespace WebAPi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GuestsController : ControllerBase
    {
        private static List<Guest> Guests = new List<Guest>() { new Guest { day=1, size="2"} };
        private static List<GuestModel> guests = new()
        {
            new GuestModel { Id = 1, FirstName = "John", LastName = "Boli", Room = (new List<Guest>() { new Guest { day = 3, size = "122" } }) },
            new GuestModel { Id = 2, FirstName = "Tim", LastName = "Corey", Room = (new List<Guest>() { new Guest { day = 33, size = "121" } }) },
            new GuestModel { Id = 3, FirstName = "Boy", LastName = "Grak", Room=(new List<Guest>() { new Guest { day=1,size="12"} } ) }  
        };




        // GET: api/<GuestsController>
        [HttpGet]
        public IEnumerable<GuestModel> Get()
        {
            return guests;
        }

        // GET api/<GuestsController>/5
        [HttpGet("{id}")]
        public GuestModel Get(int id)
        {
            return guests.Where(g => g.Id == id ).FirstOrDefault();
        }

        // POST api/<GuestsController>
        [HttpPost]
        public void Post([FromBody] GuestModel value)
        {
            guests.Add(value);
        }

        // PUT api/<GuestsController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] GuestModel value)
        {
            guests.Remove(guests.Where(g => g.Id == id).FirstOrDefault());
            guests.Add(value);
        }

        // DELETE api/<GuestsController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            guests.Remove(guests.Where(g => g.Id == id).FirstOrDefault());
        }
    }
}
