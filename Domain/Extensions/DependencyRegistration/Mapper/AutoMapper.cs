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
                #region User
                cfg.AddProfile(new UserProfile()); 
                #endregion
                #region Insurance Title
                cfg.AddProfile(new InsuranceTitleProfile());
                cfg.AddProfile(new InsuranceTitleLanguageDataProfile()); 
                #endregion Insurance Title
                #region Order
                cfg.AddProfile(new OrderProfile());
                #endregion Order
                #region Person
                cfg.AddProfile(new PersonProfile());
                cfg.AddProfile(new PersonLanguageDataProfile());
                #endregion Person
                #region Company
                cfg.AddProfile(new CompanyProfile());
                cfg.AddProfile(new CompanyLanguageDataProfile());
                #endregion Company
                #region User Detail Field
                cfg.AddProfile(new UserDetailFieldProfile());
                cfg.AddProfile(new UserDetailFieldLanguageDataProfile());
                #endregion User Detail Field
            });
            var mapper = Config.CreateMapper();
            services.AddSingleton(mapper);
            return services;
        }
    }
}
