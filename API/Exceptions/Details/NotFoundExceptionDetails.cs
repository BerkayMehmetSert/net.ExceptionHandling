using Microsoft.AspNetCore.Mvc;

namespace API.Exceptions.Details;

public class NotFoundExceptionDetails : ProblemDetails
{
    public NotFoundExceptionDetails(string detail)
    {
        Title = "Not found exception";
        Status = StatusCodes.Status404NotFound;
        Detail = detail;
        Type = "https://example.com/not-found-exception";
    }
}