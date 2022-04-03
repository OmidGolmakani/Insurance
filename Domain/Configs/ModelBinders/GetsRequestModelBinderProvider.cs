using Domain.Models.Binders;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.AspNetCore.Mvc.ModelBinding.Binders;
using System;

namespace Domain.Configs.ModelBinders
{
    public class GetsRequestModelBinderProvider : IModelBinderProvider
    {
        public IModelBinder GetBinder(ModelBinderProviderContext context)
        {
            if (context is null) throw new ArgumentNullException(nameof(context));

            // our binders here
            if (context.Metadata.ModelType.BaseType == typeof(Domain.Models.Dtos.Fundamentals.Requests.GetsRequest))
            {
                return new BinderTypeModelBinder(typeof(GetsRequestModelBinder));
            }

            // your maybe have more binders?
            // ....

            // this provider does not provide any binder for given type
            //   so we return null
            return null;
        }
    }
}
