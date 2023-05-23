using Microsoft.AspNetCore.Mvc;

namespace API.Exceptions.Details;

public class BusinessExceptionDetails : ProblemDetails
{
    public BusinessExceptionDetails(string detail)
    {
        Title = "Business rule exception";
        Status = StatusCodes.Status400BadRequest;
        Detail = detail;
        Type = "https://example.com/business-rule-exception";
    }
}