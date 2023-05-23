using API.Exceptions.Middleware;

namespace API.Exceptions;

public static class ExceptionExtensions
{
    public static void UseCustomExceptionHandler(this IApplicationBuilder app)
    {
        app.UseMiddleware<ExceptionMiddleware>();
    }
}