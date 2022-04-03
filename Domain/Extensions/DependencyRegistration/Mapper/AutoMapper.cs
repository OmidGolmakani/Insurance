using Domain.Configs.AutoMapper.Global;
using Microsoft.Extensions.DependencyInjection;

namespace Domain.Extensions.DependencyRegistration.Mapper
{
    public static class _AutoMapper
    {
        public static IServiceCollection AddAutoMapperConfig(this IServiceCollection services)
        {
            var Config = new AutoMapper.MapperConfiguration(cfg =>
            {
                cfg.AddProfile(new UserProfile());
                cfg.AddProfile(new InsuranceTitleProfile());
                cfg.AddProfile(new InsuranceTitleLanguageDataProfile());
                cfg.AddProfile(new OrderProfile());

            });
            var mapper = Config.CreateMapper();
            services.AddSingleton(mapper);
            return services;
        }
    }
}
