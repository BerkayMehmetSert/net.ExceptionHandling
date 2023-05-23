using Microsoft.AspNetCore.Mvc;

namespace API.Exceptions.Details;

public class InternalServerErrorDetails : ProblemDetails
{
    public InternalServerErrorDetails(string detail)
    {
        Title = "Internal server error";
        Status = StatusCodes.Status500InternalServerError;
        Detail = detail;
        Type = "https://example.com/internal-server-error";
    }
}