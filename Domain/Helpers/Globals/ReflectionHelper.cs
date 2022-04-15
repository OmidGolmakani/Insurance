using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using static Domain.Helpers.Globals.ReflectionHelper.Enums;

namespace Domain.Helpers.Globals
{
    public class ReflectionHelper
    {
        Assembly CurrentAssembly = Assembly.GetExecutingAssembly();
        public virtual List<System.Type> GetTypesInNamespace(string nameSpace)
        {
            return CurrentAssembly.GetTypes().ToList().Where(t => String.Equals(t.Namespace, nameSpace, StringComparison.Ordinal)).ToList();
        }
        public virtual List<Type> GetInheritedClasses(Type myType, Dependency dependency)
        {
            var result = AppDomain.CurrentDomain.GetAssemblies()
             .SelectMany(assembly => assembly.GetTypes())
             .Where(type => (dependency == Dependency.Class ? type.IsClass == true :
                             dependency == Dependency.Interface ? type.IsInterface == true :
                             1 == 1)
                             && type.IsAssignableFrom(myType)).ToList();
            return result;
        }
        public virtual void Register(string nameSpace, IServiceCollection services, registerType registerType)
        {
            foreach (Type type in GetTypesInNamespace(nameSpace))
            {
                var Inherited = GetInheritedClasses(type, Dependency.Interface);
                if (Inherited.Count != 0)
                {
                    switch (registerType)
                    {
                        case registerType.Scope:
                            services.AddScoped(Inherited.FirstOrDefault(), type);
                            break;
                        case registerType.Transleant:
                            services.AddScoped(Inherited.FirstOrDefault(), type);
                            break;
                        case registerType.Singletone:
                            services.AddScoped(Inherited.FirstOrDefault(), type);
                            break;
                    }
                }

            }
        }
        public class Enums
        {
            public enum registerType
            {
                Scope,
                Transleant,
                Singletone
            }
            public enum Dependency
            {
                All,
                Interface,
                Class
            }
        }

    }
}
