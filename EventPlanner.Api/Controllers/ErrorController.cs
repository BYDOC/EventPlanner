using Microsoft.AspNetCore.Mvc;

namespace EventPlanner.Api.Controllers;
public class ErrorController : ControllerBase
{
    [Route("/error")]
    public IActionResult Error()
    {
        return Problem();
    }
}