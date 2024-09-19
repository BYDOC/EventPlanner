using System.ComponentModel.DataAnnotations;
using System.Net;

namespace EventPlanner.Application.Common.Errors;
public class DuplicateEmailException :Exception, IServiceException
{
    public HttpStatusCode StatusCode => HttpStatusCode.Conflict;

    public string ErrorMessage => "Email already exists";
}