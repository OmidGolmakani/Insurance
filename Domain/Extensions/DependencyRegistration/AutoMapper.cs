using Microsoft.Extensions.DependencyInjection;

namespace Domain.Extensions.DependencyRegistration
{
    public static class _AutoMapper
    {
        internal static IServiceCollection AddAutoMapperConfig(this IServiceCollection services)
        {
            var Config = new AutoMapper.MapperConfiguration(cfg =>
            {
                //cfg.AddProfile(new UserProfile());
            });
            var mapper = Config.CreateMapper();
            services.AddSingleton(mapper);
            return services;
        }
    }
}
