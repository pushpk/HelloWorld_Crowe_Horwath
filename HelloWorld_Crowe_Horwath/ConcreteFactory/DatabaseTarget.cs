using HelloWorld_Crowe_Horwath.AbstractFactory;
using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorld_Crowe_Horwath.ConcreteFactory
{
    public class DatabaseTarget : ITarget
    {
        public void PrintHelloWorld(string msg)
        {
           //Logic to Enter msg into Database
        }
    }
}
