using Domain.Configs.AutoMapper.Global;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;
using static Domain.Helpers.Globals.ReflectionHelper;

namespace Domain.Extensions.DependencyRegistration.Mapper
{
    public static class _AutoMapper
    {
        public static IServiceCollection AddAutoMapperConfig(this IServiceCollection services)
        {
            var Config = new AutoMapper.MapperConfiguration(cfg =>
            {
                Helpers.Globals.ReflectionHelper reflectionHelper = new();
                foreach (System.Type type in reflectionHelper.GetTypesInNamespace(Helpers.ConstVariables.NameSpaces.AutoMaperConfig)
                .Where(type => type.IsClass && type.BaseType == typeof(AutoMapper.Profile)))
                {
                    var profile = Activator.CreateInstance(type);
                    cfg.AddProfile(profile as AutoMapper.Profile);

                }
            });
            var mapper = Config.CreateMapper();
            services.AddSingleton(mapper);
            return services;
        }
    }
}
