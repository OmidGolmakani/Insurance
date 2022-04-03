using Microsoft.AspNetCore.Mvc;
using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.SwaggerGen;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;

namespace Domain.Configs.Swagger
{
    public class SwaggerHeaderParameters : IOperationFilter
    {
        private readonly IWebHostEnvironment _env;

        public SwaggerHeaderParameters(IWebHostEnvironment env)
        {
            this._env = env;
        }
        public void Apply(OpenApiOperation operation, OperationFilterContext context)
        {
            if (operation.Parameters == null)
                operation.Parameters = new List<OpenApiParameter>();

            if (_env.IsDevelopment() == false && CorsOrginReqired(context))
            {
                operation.Parameters.Add(new OpenApiParameter
                {
                    Name = "Access-Control-Allow-Credentials",
                    In = ParameterLocation.Header,
                    Required = true
                });
                operation.Parameters.Add(new OpenApiParameter
                {
                    Name = "Access-Control-Allow-Origin",
                    In = ParameterLocation.Header,
                    Required = true
                });
            }
            if (AcceptLanguage(context))
            {
                operation.Parameters.Add(new OpenApiParameter
                {
                    Name = "Accept-Language",
                    In = ParameterLocation.Header,
                    Required = false,
                    AllowEmptyValue = true,
                    AllowReserved = true,
                    Schema = new OpenApiSchema()
                    {
                        Nullable = true
                    }
                });
            }
        }
        private bool CorsOrginReqired(OperationFilterContext context)
        {
            return context.MethodInfo.CustomAttributes.Any(attribute =>
            attribute.AttributeType == typeof(HttpDeleteAttribute) ||
            attribute.AttributeType == typeof(HttpPutAttribute) ||
            attribute.AttributeType == typeof(HttpPatchAttribute));
        }
        private bool AcceptLanguage(OperationFilterContext context)
        {
            foreach (var ConstructorArguments in context.MethodInfo.CustomAttributes.ToList().Select(p => p.ConstructorArguments).ToList())
            {
                foreach (var value in ConstructorArguments)
                {
                    if (Helpers.ConstVariables.HttpNames.AcceptLanguageMethods.FirstOrDefault(x => x == value.Value?.ToString()) != null)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
    }
}
