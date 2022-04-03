using Domain.Extensions.DependencyRegistration;
using Domain.Extensions.DependencyRegistration.Mapper;
using Domain.Extensions.DependencyRegistration.Repositories;
using Domain.Filters;
using FluentValidation.AspNetCore;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;


namespace OnlineSellAPI
{
    public class Startup
    {
        public IConfiguration _configuration { get; }
        public IWebHostEnvironment _env { get; }
        readonly string Origins = "Insurance";
        public Startup(IConfiguration configuration,
                       IWebHostEnvironment env)
        {
            this._configuration = configuration;
            this._env = env;
        }
        public void ConfigureServices(IServiceCollection services)
        {


            services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme);
            services.AddCors(options =>
            {
                options.AddPolicy(Origins, builder => builder
                    //.SetIsOriginAllowed((host) => true)
                    //.AllowAnyMethod()
                    //.AllowAnyHeader()
                    //.AllowCredentials()
                    .WithOrigins("https://localhost:5001")
                    );
            });
            services.AddHttpContextAccessor();
            services.AddSwagger(_env);
            services.MyIdentity();
            services.AddValidations();
            services.AddDataServises();
            services.BindSettings(_configuration);
            services.AddAutoMapperConfig();
            services.AddRepositories();
            services.AddGlobalServises(_configuration, typeof(Startup));
            services.AddControllers(config=>
            {
                config.ModelBinderProviders.Insert(0, new Domain.Configs.ModelBinders.GetsRequestModelBinderProvider());
            });
            if (_env.IsDevelopment() == false)
            {
                services.AddMvc(config =>
                {
                    config.Filters.Add(new CustomExceptionFilter());
                    config.Filters.Add(new CustomAuthorizationFilter());
                }).AddFluentValidation();
            }
            else
            {
                services.AddMvc(config =>
                {
                }).AddFluentValidation();
            }
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {

                //app.ConfigureExceptionHandler(logger);
            }
            else
            {
                //app.ConfigureExceptionHandler(logger);
            }

            app.UseDeveloperExceptionPage();
            app.UseSwagger();
            app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "Insurance v1"));
            app.UseHttpsRedirection();

            app.UseRouting();
            app.UseCors(Origins);

            app.UseStaticFiles();
            //app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });

        }
    }
}
