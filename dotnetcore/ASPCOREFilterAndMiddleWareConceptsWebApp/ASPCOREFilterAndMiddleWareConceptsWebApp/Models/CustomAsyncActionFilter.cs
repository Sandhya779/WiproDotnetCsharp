
using Microsoft.AspNetCore.Mvc.Controllers;
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc.Filters;

namespace ASPCOREFilterAndMiddleWareConceptsWebApp.Models
{
    public class CustomAsyncActionFilter : IAsyncActionFilter

    {
        public async Task OnActionExecutionAsync(ActionExecutingContext context, 
            ActionExecutionDelegate next)
        {

            var actionDescriptor = context.ActionDescriptor as ControllerActionDescriptor;

            string actionName, controllerName;

            if (actionDescriptor != null)
            {
                // Getting the action name
                actionName = actionDescriptor.ActionName;
                //Getting the contoller name
                controllerName = actionDescriptor.ControllerName;

                //Console.WriteLine($"Action Name: {actionName}");



                //string ? actionName = (string)filterContext.RouteData.Values["action"];
                //To do : before the action executes  
                //Pre process logic
                Trace.WriteLine($"Action has Executing at  {DateTime.Now.ToString()} Action Name: {actionName} ControllerName : {controllerName}");

                await next();
                //To do : after the action executes  
                //Post process logic
                Trace.WriteLine("Action has Executed at " + DateTime.Now.ToString());
            }
        }
    }
}
