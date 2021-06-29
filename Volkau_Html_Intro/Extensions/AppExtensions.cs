using Microsoft.AspNetCore.Builder;
using Volkau_Html_Intro.Middleware;

namespace Volkau_Html_Intro.Extensions
{
    public static class AppExtensions
    {
        public static IApplicationBuilder UseFileLogging(this IApplicationBuilder app)
        {
          return app.UseMiddleware<LogMiddleware>();
        }
    }
}
