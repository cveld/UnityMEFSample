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
        /// <summary>
        /// Scans file system for particular assemblies, loads them en kicks off IModule implementations
        /// </summary>
        static void TestWithMEF()
        {
            var container = CompositionRoot.ConfigureWithMEF();
            Class1 c = container.Resolve<Class1>();
            Console.WriteLine(c.MyMethod("ConsoleApp1 with MEF"));

        }

        /// <summary>
        /// Scans all loaded assemblies for the presence of interface IModule
        /// </summary>
        static void TestWithUnity()
        {
            var container = CompositionRoot.ConfigureWithUnity();
            Class1 c = container.Resolve<Class1>();
            Console.WriteLine(c.MyMethod("ConsoleApp1 with Unity"));
        }

        static void Main(string[] args)
        {
            TestWithMEF();
            TestWithUnity();
            Console.ReadLine();
        }
    }
}
