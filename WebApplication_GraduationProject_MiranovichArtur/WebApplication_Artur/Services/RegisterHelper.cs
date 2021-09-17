using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication_Artur.Services
{
    public static class RegisterHelper
    {
        public static void RegisterAssistant<T>(this IServiceCollection services)
        {
            var type = typeof(T);
            RegisterAssistant(services, type);
        }

        public static void RegisterAssistant(this IServiceCollection services, Type type)
        {
            services.AddScoped(type, serviceProvider =>
            {
                var constructor = type.GetConstructors()
                    .OrderByDescending(x => x.GetParameters().Length)
                    .First();

                var parametorsInfo = constructor.GetParameters();
                var parametorsValue = parametorsInfo
                .Select(p => serviceProvider.GetService(p.ParameterType))
                .ToArray();

                return constructor.Invoke(parametorsValue);
            });
        }
    }
}
