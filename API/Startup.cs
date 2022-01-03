using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Domain.Extensions.DependencyRegistration;
using Domain.Filters;
using FluentValidation.AspNetCore;

namespace CustomerAPI
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
            services.AddSwagger(_env);
            services.MyIdentity();
            services.AddAutoMapperConfig();
            services.AddRepositores();
            services.AddServises(_configuration, typeof(Startup));
            services.AddControllersWithViews().AddFluentValidation();
            services.AddControllers();
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
                services.AddMvc().AddFluentValidation();
            }
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapGet("/", async context =>
                {
                    await context.Response.WriteAsync("Hello World!");
                });
            });
        }
    }
}
