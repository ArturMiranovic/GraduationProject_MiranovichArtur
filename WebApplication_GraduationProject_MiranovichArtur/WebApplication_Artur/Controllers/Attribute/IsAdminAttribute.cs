using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication_Artur.Services;

namespace WebApplication_Artur.Controllers.Attribute
{
    public class IsAdminAttribut : ActionFilterAttribute
    {
        public override void OnActionExecuted(ActionExecutedContext context)
        {
            var userService = context
                .HttpContext
                .RequestServices
                .GetService(typeof(UserService)) as UserService;

            if (!userService.IsAdmin())
            {
                context.Result = new ForbidResult();
            }

            base.OnActionExecuted(context);
        }
    }
}
