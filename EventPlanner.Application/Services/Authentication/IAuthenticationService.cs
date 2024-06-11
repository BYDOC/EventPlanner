using ErrorOr;

namespace EventPlanner.Application.Services.Authentication
{
    public interface IAuthenticationService
    {
        //contracts'dan hiçbir şey application'a geçmemeli. Bu yüzden burada AuthenticationResponse olusturmalıyız.
        ErrorOr<AuthenticationResult> Register(string firstname, string lastname, string email, string password);
        ErrorOr<AuthenticationResult> Login(string email, string password);
    }
}