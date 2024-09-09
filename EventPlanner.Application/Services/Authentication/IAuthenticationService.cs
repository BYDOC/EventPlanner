namespace EventPlanner.Application.Services.Authentication;

//contractdan application'a referans yok.
public interface IAuthenticationService{
    public AuthenticationResult Login(string email, string password);
    public AuthenticationResult Register(string firstName, string lastName, string email, string password);
}   