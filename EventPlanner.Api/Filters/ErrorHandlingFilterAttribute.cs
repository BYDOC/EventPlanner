using System.Net;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace EventPlanner.Api.Filters;

public class ErrorHandlingFilterAttribute:ExceptionFilterAttribute
{
    public override void OnException(ExceptionContext context)
    {
        var exception = context.Exception;
        var problemDetails = new ProblemDetails
        {
            Title = "An error occured while processing your request.",
            Status = (int)HttpStatusCode.InternalServerError,
            Detail = exception.Message,
            Instance = context.HttpContext.Request.Path,
            Extensions = {{"traceId",context.HttpContext.TraceIdentifier}},
            Type = "https://tools.ietf.org/html/rfc7231#section-6.6.1"
        };

        context.Result = new ObjectResult(problemDetails); // ObjectResult checks if parameter is ProblemDetails

        context.ExceptionHandled=true;
    }
}