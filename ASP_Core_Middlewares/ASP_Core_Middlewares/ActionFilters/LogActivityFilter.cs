using Microsoft.AspNetCore.Mvc.Filters;
using System.Text.Json;

namespace ASP_Core_Middlewares.ActionFilters
{
    public class LogActivityFilter : IActionFilter
    {
        private readonly ILogger _logger;
        public LogActivityFilter(ILogger<LogActivityFilter> logger)
        {
            _logger = logger;
        }

        public void OnActionExecuting(ActionExecutingContext context)
        {
            _logger.LogInformation(
                $"Executing Action {context.ActionDescriptor.DisplayName} on Controller {context.Controller} with arguments {JsonSerializer.Serialize(context.ActionArguments)}");
        }


        public void OnActionExecuted(ActionExecutedContext context)
        {
            _logger.LogInformation(
               $"Action {context.ActionDescriptor.DisplayName} Finished executed on Controller {context.Controller}.");
        }

    }
}
