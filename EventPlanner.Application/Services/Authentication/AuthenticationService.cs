namespace EventPlanner.Application.Services.Authentication;

public class AuthenticationService : IAuthenticationService
{
    public AuthenticationResult Login(string email, string password)
    {
       return new AuthenticationResult(Guid.NewGuid(), "John", "Doe", email,"token");
    }

    public AuthenticationResult Register(string firstname, string lastname, string email, string password)
    {
       return new AuthenticationResult(Guid.NewGuid(), firstname, lastname, email,"token");
    }
}
