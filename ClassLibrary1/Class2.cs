using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary1
{
    public class Class2 : Interface2
    {
        public string MyMethod2(string str)
        {
            return $"Greetings {str}";
        }
    }
}
