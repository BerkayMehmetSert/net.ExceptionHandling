using System.ComponentModel.DataAnnotations;
using API.Exceptions.Type;

namespace API.Exceptions.Handler;

public abstract class ExceptionHandler
{
    public Task HandleExceptionAsync(Exception exception)
    {
        return exception switch
        {
            BusinessException businessException => HandleException(businessException),
            NotFoundException notFoundException => HandleException(notFoundException),
            _ => HandleException(exception)
        };
    }

    protected abstract Task HandleException(BusinessException businessException);
    protected abstract Task HandleException(NotFoundException notFoundException);
    protected abstract Task HandleException(Exception exception);
}