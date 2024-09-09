using EventPlanner.Application.Common.Interfaces.Authentication;

namespace EventPlanner.Application.Services.Authentication;

public class AuthenticationService : IAuthenticationService
{
    public AuthenticationService(IJwtTokenGenerator jwtTokenGenerator)
    {
        _jwtTokenGenerator=jwtTokenGenerator;
    }
    private readonly IJwtTokenGenerator _jwtTokenGenerator;

    public AuthenticationResult Register(string firstName, string lastName, string email, string password)
    {
        //check if user exist
        //create user (generate unique Id)
        //create token

        Guid userId = Guid.NewGuid();
        
        var token = _jwtTokenGenerator.GenerateToken(userId,firstName,lastName);
        return new AuthenticationResult(userId, firstName, lastName, email, token);
    }
    public AuthenticationResult Login(string email, string password)
    {
        //check if user exist
        //
        return new AuthenticationResult(Guid.NewGuid(), "firstName", "lastName", email, "token");
    }

    
}
