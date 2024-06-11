using EventPlanner.Application.Common.Interfaces.Authentication;
using EventPlanner.Application.Common.Interfaces.Services;
using EventPlanner.Infrastructure.Authentication;
using EventPlanner.Infrastructure.Services;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;
namespace EventPlanner.Infrastructure;

public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services,
        ConfigurationManager configuration)
    {
        services.Configure<JwtSettings>(configuration.GetSection(JwtSettings.SectionName));
        services.AddSingleton<IJwtTokenGenerator, JwtTokenGenerator>();
        services.AddSingleton<IDateTimeProvider, DateTimeProvider>();
        return services;
    }
}