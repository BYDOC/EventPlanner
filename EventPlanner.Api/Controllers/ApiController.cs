using System.Security.Cryptography;
using ErrorOr;
using EventPlanner.Api.Common.Http;
using Microsoft.AspNetCore.Mvc;

namespace EventPlanner.Api.Controllers;

[ApiController]
public class ApiController:ControllerBase
{
    protected IActionResult Problem(List<Error> errors)
    {
        HttpContext.Items[HttpContextItemKeys.Errors]=errors;

        var firstError = errors[0];
        var statusCode=firstError.Type switch 
        {
            ErrorType.Validation => StatusCodes.Status400BadRequest,
            ErrorType.Conflict => StatusCodes.Status409Conflict,
            ErrorType.NotFound => StatusCodes.Status400BadRequest,
            _ => StatusCodes.Status500InternalServerError
            
        };
        return Problem(statusCode:statusCode, title:firstError.Description);
    }
}