using EventPlanner.Domain.Entities;

namespace EventPlanner.Application.Authentication.Common;

public record AuthenticationResult(
    User User,
    string Token);


