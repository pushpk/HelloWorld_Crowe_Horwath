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
        private readonly IGreeting _greeting;

        public HelloWorldController(IGreeting greeting)
        {
            _greeting = greeting;
        }

        [HttpGet]
        public string Get()
        {
            return _greeting.GreetingMsg;
        }
    }
}
