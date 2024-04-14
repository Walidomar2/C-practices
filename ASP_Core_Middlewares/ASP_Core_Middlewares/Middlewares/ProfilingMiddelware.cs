using System.Diagnostics;

namespace ASP_Core_Middlewares.Middlewares
{
    public class ProfilingMiddelware
    {
        private readonly RequestDelegate _next;
        private readonly ILogger _logger;
        public ProfilingMiddelware(RequestDelegate next, ILogger<ProfilingMiddelware> logger)
        {
            _next = next;
            _logger = logger;
        }

        public async Task Invoke(HttpContext context)
        {
            var stopwatch = new Stopwatch();
            stopwatch.Start();
            await _next(context);
            stopwatch.Stop();
            _logger.LogInformation($"Request {context.Request.Path} took {stopwatch.ElapsedMilliseconds}ms to execute");

        }

    }
}
