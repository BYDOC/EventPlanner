using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using EventPlanner.Application.Common.Interfaces.Authentication;
using EventPlanner.Application.Common.Interfaces.Services;
using Microsoft.IdentityModel.Tokens;

namespace EventPlanner.Infrastructure.Authentication;

public class JwtTokenGenerator : IJwtTokenGenerator
{
    private readonly IDateTimeProvider _dateTimeProvider;
    public JwtTokenGenerator(IDateTimeProvider dateTimeProvider)
    {
        _dateTimeProvider=dateTimeProvider;
    }
    public string GenerateToken(Guid userId, string firstName, string lastName)
    {
        var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("super-secret-keysuper-secret-key"));
        var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);

        var claims = new[]
        {
            new Claim(JwtRegisteredClaimNames.Sub, firstName + " "+ lastName),
            new Claim(JwtRegisteredClaimNames.GivenName, firstName),
            new Claim(JwtRegisteredClaimNames.FamilyName, lastName),           
            new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString())
        };



        var token = new JwtSecurityToken(
            issuer: "EventPlanner",
            claims: claims,
            expires: _dateTimeProvider.UtcNow.AddMinutes(60),
            signingCredentials: credentials
        );
        return new JwtSecurityTokenHandler().WriteToken(token);
    }
}
