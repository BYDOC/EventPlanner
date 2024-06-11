using EventPlanner.Application.Common.Interfaces.Authentication;

namespace EventPlanner.Application.Services.Authentication;

public class AuthenticationService : IAuthenticationService
{
   private readonly IJwtTokenGenerator _jwtTokenGenerator;

   public AuthenticationService(IJwtTokenGenerator jwtTokenGenerator)
   {
      _jwtTokenGenerator = jwtTokenGenerator;
   }

   public AuthenticationResult Register(string firstname, string lastname, string email, string password)
   {
      //check if user already exists

      //create user (generate unique id)
      //generate token  
      
      Guid userId = Guid.NewGuid();
      var token = _jwtTokenGenerator.GenerateToken(userId, firstname, lastname);
      
      return new AuthenticationResult(userId,
          firstname,
          lastname,
          email,
          token);
   }
   public AuthenticationResult Login(string email, string password)
   {
      return new AuthenticationResult(Guid.NewGuid(), "John", "Doe", email, "token");
   }

}
