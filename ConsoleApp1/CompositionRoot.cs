using ClassLibrary1;
using Common;
using Unity;

namespace ConsoleApp1
{
    internal class CompositionRoot
    {
        public static IUnityContainer Configure()
        {
            var container = new UnityContainer();

            //register dependency injection
            //container
            //    .RegisterType<Interface1, Class1>();                

            //load libraries from given folder
            ModuleLoader.LoadContainer(container, ".\\", "ClassLibrary1.dll");

            return container;
        }
    }
}