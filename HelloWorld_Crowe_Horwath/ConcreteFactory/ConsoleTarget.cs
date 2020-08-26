using HelloWorld_Crowe_Horwath.AbstractFactory;
using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorld_Crowe_Horwath.ConcreteFactory
{
    public class ConsoleTarget : ITarget
    {
        public void PrintHelloWorld(string msg)
        {
            Console.WriteLine(msg);
        }
    }
}
