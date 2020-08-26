using HelloWorld_Crowe_Horwath.AbstractTarget;
using HelloWorld_Crowe_Horwath.ConcreteTarget;
using System;
using System.Collections.Generic;
using System.Text;
using static HelloWorld_Crowe_Horwath.Helper.TargetTypeEnum;

namespace HelloWorld_Crowe_Horwath.Factory
{
    public class TargetFactory
    {
        public static ITarget Create(TargetTypes targetType)
        {
            switch (targetType)
            {
                case TargetTypes.Console:
                    return new ConsoleTarget();
                case TargetTypes.Database:
                    return new DatabaseTarget();
                default:
                    throw new NotImplementedException();
            }
        }
    }
}
