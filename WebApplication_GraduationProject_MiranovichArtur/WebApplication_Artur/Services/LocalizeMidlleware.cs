using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication_Artur.Services
{
    public class LocalizeMidlleware
    {
        private readonly RequestDelegate _next;

        public LocalizeMidlleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task Invoke(HttpContext context)
        {
            var userService = context
                .RequestServices.GetService(typeof(UserService)) as UserService;

            var user = userService.GetCurrent();

            if (user == null)
            {
                CultureInfo.DefaultThreadCurrentUICulture = new CultureInfo("en-EN");
            }
            else
            {
                switch (user.Lang)
                {
                    case EfStuff.Model.UserModel.Lang.Rus:
                        CultureInfo.DefaultThreadCurrentUICulture = new CultureInfo("ru-RU");
                        break;

                    case EfStuff.Model.UserModel.Lang.Eng:
                        CultureInfo.DefaultThreadCurrentUICulture = new CultureInfo("en-EN");
                        break;

                    case EfStuff.Model.UserModel.Lang.Es:
                        CultureInfo.DefaultThreadCurrentUICulture = new CultureInfo("es-Es");
                        break;
                }
            }

            await _next(context);
        }
    }
}
