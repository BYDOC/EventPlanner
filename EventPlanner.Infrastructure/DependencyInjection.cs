using EventPlanner.Application.Common.Interfaces.Authentication;
using EventPlanner.Application.Common.Interfaces.Services;
using EventPlanner.Infrastructure.Authentication;
using EventPlanner.Infrastructure.Services;
using Microsoft.Extensions.DependencyInjection;

namespace EventPlanner.Infrastructure;
public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services)
    {
      services.AddSingleton<IJwtTokenGenerator, JwtTokenGenerator>();
      services.AddSingleton<IDateTimeProvider, DateTimeProvider>();
       return services;
    }
}