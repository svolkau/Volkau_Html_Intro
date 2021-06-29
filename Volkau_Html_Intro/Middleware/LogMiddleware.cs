﻿using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using System.Threading.Tasks;

namespace Volkau_Html_Intro.Middleware
{
    public class LogMiddleware
    {
        private RequestDelegate _next;
        private ILogger<LogMiddleware> _logger;

        public LogMiddleware(RequestDelegate next, ILogger<LogMiddleware> logger)
        {
            _next = next;
            _logger = logger;
        }

        public async Task Invoke(HttpContext context) {
            await _next.Invoke(context);
            if (context.Response.StatusCode != StatusCodes.Status200OK)
            {
                var path = context.Request.Path +
                    context.Request.QueryString;
                _logger.LogInformation($"Request {path} returns status code {context.Response.StatusCode.ToString()}");
            }
        }
    }
}