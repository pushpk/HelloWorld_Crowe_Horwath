using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorld_Crowe_Horwath.Helper
{
   public class ParseEnumHelper
    {
        public static T ParseEnum<T>(string value)
        {
            return (T)Enum.Parse(typeof(T), value, ignoreCase: true);
        }
    }
}
