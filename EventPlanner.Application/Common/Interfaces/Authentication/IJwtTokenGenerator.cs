using EventPlanner.Domain.Entities;

namespace EventPlanner.Application.Common.Interfaces.Authentication;

public interface IJwtTokenGenerator
{
    string GenerateToken(User user );
}