using System;
using Unity;
using Unity.Lifetime;
using Unity.Registration;
namespace Common
{
     public class ModuleRegistrar : IModuleRegistrar
    {
        private readonly IUnityContainer _container;

        public ModuleRegistrar(IUnityContainer container)
        {
            _container = container;
            //Register interception behaviour if any
        }

        public void RegisterInstance<TInterface>(string name, TInterface instance)
        {
            _container.RegisterInstance<TInterface>(name, instance);
        }

        public void RegisterType<TFrom, TTo>(bool withInterception = false) where TTo : TFrom
        {
            RegisterType<TFrom, TTo>(null, withInterception);
        }

        public void RegisterType<TFrom, TTo>(InjectionMember[] injectionMembers, bool withInterception = false) where TTo : TFrom
        {

            if (withInterception)
            {
                //register with interception 
            }
            else
            {
                _container.RegisterType<TFrom, TTo>(injectionMembers ?? new InjectionMember[0]);
            }
        }

        public void RegisterType<TFrom, TTo>(string name, InjectionMember[] injectionMembers, bool withInterception = false) where TTo : TFrom
        {

            if (withInterception)
            {
                //register with interception 
            }
            else
            {
                _container.RegisterType<TFrom, TTo>(name, injectionMembers ?? new InjectionMember[0]);
            }
        }

        public void RegisterTypeWithContainerControlledLife<TFrom, TTo>(bool withInterception = false) where TTo : TFrom
        {
            _container.RegisterType<TFrom, TTo>(new ContainerControlledLifetimeManager());
        }

        public TInterface Resolve<TInterface>(string name)
        {
            return _container.Resolve<TInterface>(name);
        }

        public TInterface Resolve<TInterface>()
        {
            return _container.Resolve<TInterface>();
        }

        public object Resolve(Type toType, string name)
        {
            return _container.Resolve(toType, name);
        }
    }
}
