using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;

namespace WebAPi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TestAPi: ControllerBase
    {
        private readonly ILogger<TestAPi> _logger;
        public TestAPi(ILogger<TestAPi> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<nomber> Get()
        {
            var rng = new Random();
            return Enumerable.Range(1, 20).Select(index => new nomber
            {
                numbers = rng.Next(1, 200),

            })
            .ToArray();
        }
    }
}
