using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Unity;
using Unity.RegistrationByConvention;

namespace Common
{
    public class ModuleLoaderWithUnity
    {
        public static void InitializeAllModules(UnityContainer container)
        {
            var result = AllClasses.FromLoadedAssemblies().
                Where(type => typeof(IModule).IsAssignableFrom(type));

            var registrar = new ModuleRegistrar(container);

            foreach (var moduletype in result)
            {
                var resolve = container.Resolve(moduletype);

                ((IModule)resolve).Initialize(registrar);
            }
        }
    }
}
