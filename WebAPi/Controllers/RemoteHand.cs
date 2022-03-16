using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;

namespace WebAPi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RemoteHand : ControllerBase
    {
        private readonly ILogger<TestAPi> _logger;
        public RemoteHand(ILogger<TestAPi> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<int> Get()
        {

            return 0;
        }
    }
}
