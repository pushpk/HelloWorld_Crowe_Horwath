using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HelloWorld_Crowe_Horwath_API_Services.Models
{
    public class HelloWorldGreeting : IGreeting
    {
        public string GreetingMsg => "Hello World";
    }
}
