namespace EventPlanner.Application.Services.Authentication;

public record AuthenticationResult(
    Guid id,
    string FirstName,
    string Lastname,
    string Email,
    string Token);
