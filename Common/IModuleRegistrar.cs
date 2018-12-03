using System;
using Unity.Registration;

namespace Common
{
    /// <summary>
    /// Allows objects implementing IModule to register types in unity.
    /// </summary>
    public interface IModuleRegistrar
    {
        void RegisterType<TFrom, TTo>(bool withInterception = false) where TTo : TFrom;

        void RegisterType<TFrom, TTo>(InjectionMember[] injectionMembers, bool withInterception = false) where TTo : TFrom;

        void RegisterType<TFrom, TTo>(string name, InjectionMember[] injectionMembers, bool withInterception = false) where TTo : TFrom;

        void RegisterTypeWithContainerControlledLife<TFrom, TTo>(bool withInterception = false) where TTo : TFrom;

        void RegisterInstance<TInterface>(string name, TInterface instance);

        TInterface Resolve<TInterface>();

        TInterface Resolve<TInterface>(string name);

        object Resolve(Type toType, string name);
    }
}
