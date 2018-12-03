using ClassLibrary1;
using Common;
using System.Linq;
using Unity;
using Unity.RegistrationByConvention;

namespace ConsoleApp1
{
    internal class CompositionRoot
    {
        public static IUnityContainer ConfigureWithMEF()
        {
            var container = new UnityContainer();
            //load libraries from given folder
            ModuleLoaderWithMEF.LoadContainer(container, ".\\", "ClassLibrary1.dll");            
            return container;
        }
        public static IUnityContainer ConfigureWithUnity()
        {
            var container = new UnityContainer();
            ModuleLoaderWithUnity.InitializeAllModules(container);
            return container;
        }
    }
}