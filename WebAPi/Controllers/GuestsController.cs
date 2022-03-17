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

        private static List<GuestModel> guests = new()
        {
            new GuestModel { Id = 1, FirstName = "John", LastName = "Boli" },
            new GuestModel { Id = 2, FirstName = "Tim", LastName = "Corey" },
            new GuestModel { Id = 3, FirstName = "Boy", LastName = "Grak" }
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
