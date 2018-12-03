using System;

namespace ClassLibrary1
{
    public class Class1 : Interface1
    {
        private readonly Interface2 class2;

        public Class1(Interface2 class2)
        {
            this.class2 = class2;
        }
        public string MyMethod(string parameter)
        {
            return $"Hello {parameter}; {class2.MyMethod2(parameter)}";
        }
    }
}
