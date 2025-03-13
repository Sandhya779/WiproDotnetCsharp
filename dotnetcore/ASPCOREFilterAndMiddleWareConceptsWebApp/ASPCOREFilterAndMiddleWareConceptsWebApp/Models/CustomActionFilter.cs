using System.Diagnostics;
using Microsoft.AspNetCore.Mvc.Filters;
namespace ASPCOREFilterAndMiddleWareConceptsWebApp.Models
{
    public class CustomActionFilter : IActionFilter
    {
        public void OnActionExecuted(ActionExecutedContext context)
        {
            //post processing logic
            Trace.WriteLine("Action has executed at "+DateTime.Now.ToString());
        }

        public void OnActionExecuting(ActionExecutingContext context)
        {
            //pre processing logic
            Trace.WriteLine("Action has executing  at " + DateTime.Now.ToString());
        }
    }
}
