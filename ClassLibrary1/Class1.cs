using System;

namespace ClassLibrary1
{
    public class Class1 : Interface1
    {
        public string MyMethod(string parameter)
        {
            return $"Hello {parameter}";
        }
    }
}
