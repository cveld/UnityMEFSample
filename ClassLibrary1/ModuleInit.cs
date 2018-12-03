using Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Diagnostics.CodeAnalysis;
using System.Text;
using Unity;

namespace ClassLibrary1
{
    [ExcludeFromCodeCoverage]
    [Export(typeof(IModule))]
    public class ModuleInit : IModule
    {


        public void Initialize(IModuleRegistrar registrar)
        {
            registrar.RegisterType<Interface1, Class1>();
        }
    }
}
