using AutoMapper;
using Domain.Extensions.Other;
using Domain.Interfaces.Fundamentals.Request;
using Domain.Models.Dtos.Fundamentals.Requests;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.ModelBinders
{
    public class GetsRequestModelBinder : IModelBinder
    {
        private readonly IMapper _mapper;

        public GetsRequestModelBinder(AutoMapper.IMapper mapper)
        {
            this._mapper = mapper;
        }
        public Task BindModelAsync(ModelBindingContext bindingContext)
        {
            if (bindingContext == null)
                throw new ArgumentNullException(nameof(bindingContext));
            var modelProperties = bindingContext.ModelType.GetProperties();
            System.Reflection.Assembly assembly = bindingContext.ModelType.Assembly;
            var model = assembly.CreateInstance(bindingContext.ModelType.FullName, true);
            List<OrderRequest> orders = new();
            foreach (var property in modelProperties)
            {
                var propertyType = Type.GetTypeCode(property.PropertyType);
                if (property.PropertyType.IsGenericType && property.PropertyType.GetGenericTypeDefinition() == typeof(Nullable<>))
                {
                    propertyType = Type.GetTypeCode(property.PropertyType.GetGenericArguments()[0]);
                }
                switch (propertyType)
                {
                    case TypeCode.Empty:
                        break;
                    case TypeCode.Boolean:
                        model.GetType().GetProperty(property.Name).SetValue(model, bindingContext.ValueProvider.GetValue(property.Name).FirstValue?.ToBoolean());
                        break;
                    case TypeCode.Char:
                        break;
                    case TypeCode.SByte:
                        break;
                    case TypeCode.Byte:
                        model.GetType().GetProperty(property.Name).SetValue(model, bindingContext.ValueProvider.GetValue(property.Name).FirstValue?.ToByte());
                        break;
                    case TypeCode.Int16:
                        model.GetType().GetProperty(property.Name).SetValue(model, bindingContext.ValueProvider.GetValue(property.Name).FirstValue?.ToInt());
                        break;
                    case TypeCode.UInt16:
                        break;
                    case TypeCode.Int32:
                        model.GetType().GetProperty(property.Name).SetValue(model, bindingContext.ValueProvider.GetValue(property.Name).FirstValue?.ToInt());
                        break;
                    case TypeCode.UInt32:
                        break;
                    case TypeCode.Int64:
                        model.GetType().GetProperty(property.Name).SetValue(model, bindingContext.ValueProvider.GetValue(property.Name).FirstValue?.ToInt());
                        break;
                    case TypeCode.UInt64:
                        break;
                    case TypeCode.Single:
                        break;
                    case TypeCode.Double:
                        model.GetType().GetProperty(property.Name).SetValue(model, bindingContext.ValueProvider.GetValue(property.Name).FirstValue?.ToDouble());
                        break;
                    case TypeCode.Decimal:
                        model.GetType().GetProperty(property.Name).SetValue(model, bindingContext.ValueProvider.GetValue(property.Name).FirstValue?.ToDecimal());
                        break;
                    case TypeCode.DateTime:
                        model.GetType().GetProperty(property.Name).SetValue(model, bindingContext.ValueProvider.GetValue(property.Name).FirstValue?.ToDateTime());
                        break;
                    case TypeCode.String:
                        model.GetType().GetProperty(property.Name).SetValue(model, bindingContext.ValueProvider.GetValue(property.Name).FirstValue?.ToString());
                        break;
                    default:
                        break;
                }
                if (property.PropertyType == typeof(List<OrderRequest>) && 
                    bindingContext.ValueProvider.GetValue(property.Name).FirstValue != null)
                {
                    foreach (var order in bindingContext.ValueProvider.GetValue(property.Name))
                    {
                        orders.Add(Newtonsoft.Json.JsonConvert.DeserializeObject<OrderRequest>(order));

                    }
                    model.GetType().GetProperty(property.Name).SetValue(model, orders);
                }
            }

            bindingContext.Result = ModelBindingResult.Success(model);
            return Task.CompletedTask;
        }
    }
}
