using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HelloWorld_Crowe_Horwath_API_Services.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace HelloWorld_Crowe_Horwath_API_Services.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HelloWorldController : ControllerBase
    {
        private readonly ILogger<HelloWorldController> _logger;
        private readonly IGreeting _greeting;

        public HelloWorldController(ILogger<HelloWorldController> logger, IGreeting greeting)
        {
            _logger = logger;
            _greeting = greeting;
        }

        [HttpGet]
        public string Get()
        {
            return _greeting.GreetingMsg;
        }
    }
}
