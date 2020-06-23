using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineWebVideoShop.ActionFilter
{
      public class ApiExceptionAttribute : ExceptionFilterAttribute
      {
            public override void OnException(ExceptionContext context)
            {
                  context.ExceptionHandled = true;
                  HttpResponse response = context.HttpContext.Response;
                  response.StatusCode = (int)200;
                  response.ContentType = "application/json";
                  context.Result = new JsonResult(new { msg = "Custom Error" });
            }
      }
}
