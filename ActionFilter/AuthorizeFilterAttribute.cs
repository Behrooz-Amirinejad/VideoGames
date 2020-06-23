using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineWebVideoShop.ActionFilter
{
      public class AuthorizeFilterAttribute : ActionFilterAttribute
      {
            public override void OnActionExecuted(ActionExecutedContext context)
            {
                  base.OnActionExecuted(context);
            }

            public override void OnActionExecuting(ActionExecutingContext context)
            {
                  base.OnActionExecuting(context);
            }
      }
}
