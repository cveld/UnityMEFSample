using ClassLibrary1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var container = CompositionRoot.Configure();

            //IUnityContainer unitycontainer = new UnityContainer();
            //unitycontainer.RegisterType<Interface1, Class1>();
            //ModuleInit.Register(unitycontainer);

            Class1 c = container.Resolve<Class1>();
            Console.WriteLine(c.MyMethod("ConsoleApp1")); 


            Console.ReadLine();
        }
    }
}
