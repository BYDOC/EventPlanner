using EventPlanner.Application.Common.Interfaces.Authentication;
using EventPlanner.Application.Common.Interfaces.Persistance;
using EventPlanner.Application.Common.Interfaces.Services;
using EventPlanner.Infrastructure.Authentication;
using EventPlanner.Infrastructure.Persistance;
using EventPlanner.Infrastructure.Services;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace EventPlanner.Infrastructure;
public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services,
    ConfigurationManager configuration)
    {
      services.Configure<JwtSettings>(configuration.GetSection(JwtSettings.SectionName));
      services.AddSingleton<IJwtTokenGenerator, JwtTokenGenerator>();
      services.AddSingleton<IDateTimeProvider, DateTimeProvider>();

      services.AddScoped<IUserRepository, UserRepository>();
       return services;
    }
}