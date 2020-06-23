using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineWebVideoShop.ActionFilter
{
      public class ApiResultFilterAttribute : ResultFilterAttribute
      {
            
            public override Task OnResultExecutionAsync(ResultExecutingContext context, ResultExecutionDelegate next)
            {
                  //var resultFromAction = context.Result as ObjectResult;
                  //resultFromAction.Value = new { status = 200  , result = resultFromAction.Value };
                  
                  return base.OnResultExecutionAsync(context, next);
            }
      }
}
