using HelloWorld_Crowe_Horwath.AbstractTarget;
using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorld_Crowe_Horwath.ConcreteTarget
{
    public class DatabaseTarget : ITarget
    {
        public void PrintHelloWorld(string msg)
        {
           //Logic to Enter msg into Database
        }
    }
}
