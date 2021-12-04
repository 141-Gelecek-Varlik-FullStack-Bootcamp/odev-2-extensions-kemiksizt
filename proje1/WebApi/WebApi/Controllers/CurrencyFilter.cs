using Extension;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Routing;
using System;

namespace WebApi.Controllers
{
    public class CurrencyFilter : Attribute, IActionFilter
    {

        string currencyType = Extensions.GetCurrencies(Extension.Enum.CurrencyTypeDollar);


        public void OnActionExecuted(ActionExecutedContext context)
        {
            context.Result = new RedirectToRouteResult(new RouteValueDictionary(new { Controller = "Home", Action = "SuccessPage" }));
        }

        public void OnActionExecuting(ActionExecutingContext context)
        {
            if(currencyType != "Dollar")
            {
                context.Result = new RedirectToRouteResult(new RouteValueDictionary(new { Controller = "Home", Action = "Error" }));
            }

            
        }
    }
}
