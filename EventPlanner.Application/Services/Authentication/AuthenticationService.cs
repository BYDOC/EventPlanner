using EventPlanner.Application.Common.Interfaces.Authentication;
using EventPlanner.Application.Common.Interfaces.Persistence;
using EventPlanner.Domain.Entities;

namespace EventPlanner.Application.Services.Authentication;

public class AuthenticationService : IAuthenticationService
{
    private readonly IJwtTokenGenerator _jwtTokenGenerator;
    private readonly IUserRepository _userRepository;

    public AuthenticationService(IJwtTokenGenerator jwtTokenGenerator, IUserRepository userRepository)
    {
        _jwtTokenGenerator = jwtTokenGenerator;
        _userRepository = userRepository;
    }

    public AuthenticationResult Register(string firstname, string lastname, string email, string password)
    {
        //validate user doesn't exist
        if (_userRepository.GetUserByEmail(email) != null)
        {
            throw new Exception("User already exists");
        }

        //create user (generate unique id) & save to db
        var user = new User
        {
            FirstName = firstname,
            LastName = lastname,
            Email = email,
            Password = password
        };
        _userRepository.Add(user);
        //generate JWT token  


        var token = _jwtTokenGenerator.GenerateToken(user);

        return new AuthenticationResult(
            user,
            token);
    }
    public AuthenticationResult Login(string email, string password)
    {
        //validate user exists
        if (_userRepository.GetUserByEmail(email) is not User user)
        {
            throw new Exception("User does not exist");
        }
        //validate password is correct
        if (user.Password != password)
        {
            throw new Exception("Invalid password");
        }
        //create JWT token
        var token = _jwtTokenGenerator.GenerateToken(user);
        return new AuthenticationResult(
            user,
            token);
    }

}
