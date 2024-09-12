using EventPlanner.Api.Errors;

using EventPlanner.Application;
using EventPlanner.Infrastructure;
using Microsoft.AspNetCore.Mvc.Infrastructure;

var builder = WebApplication.CreateBuilder(args);
{
    builder.Services.AddApplication().AddInfrastructure(builder.Configuration);

    // builder.Services.AddControllers(options=>options.Filters.Add<ErrorHandlingFilterAttribute>());
    builder.Services.AddControllers();

    builder.Services.AddSingleton<ProblemDetailsFactory, EventPlannerProblemDetailsFactory>();
}

var app = builder.Build();
{
    // app.UseMiddleware<ErrorHandlingMiddleware>();
    app.UseExceptionHandler("/error"); // Redirects to error page
    app.UseHttpsRedirection();
    app.MapControllers();
    app.Run();
}
