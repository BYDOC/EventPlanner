using EventPlanner.Application.Common.Interfaces.Services;

namespace EventPlanner.Infrastructure.Services;

public class DateTimeProvider : IDateTimeProvider
{
    public DateTime UtcNow => DateTime.UtcNow;
}