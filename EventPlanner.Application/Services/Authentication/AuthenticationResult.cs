using EventPlanner.Domain.Entities;

namespace EventPlanner.Application.Services.Authentication;

public record AuthenticationResult(
    User User,
    string Token);
