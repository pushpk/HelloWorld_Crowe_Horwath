using HelloWorld_Crowe_Horwath.AbstractTarget;
using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorld_Crowe_Horwath.ConcreteTarget
{
    public class ConsoleTarget : ITarget
    {
        public void PrintHelloWorld(string msg)
        {
            Console.WriteLine(msg);
        }
    }
}
