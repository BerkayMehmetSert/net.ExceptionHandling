using API.Exceptions.Handler;

namespace API.Exceptions.Middleware;

public class ExceptionMiddleware
{
    private readonly HttpExceptionHandler _httpExceptionHandler;
    private readonly RequestDelegate _next;

    public ExceptionMiddleware(RequestDelegate next)
    {
        _httpExceptionHandler = new HttpExceptionHandler();
        _next = next;
    }
    
    public async Task InvokeAsync(HttpContext context)
    {
        try
        {
            await _next(context);
        }
        catch (Exception exception)
        {
            await HandleExceptionAsync(context.Response, exception);
        }
    }
    
    private Task HandleExceptionAsync(HttpResponse? response, Exception exception)
    {
        response!.ContentType = "application/json";
        _httpExceptionHandler.Response = response;
        return _httpExceptionHandler.HandleExceptionAsync(exception);
    }
}