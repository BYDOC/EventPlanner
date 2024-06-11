using ErrorOr;
using EventPlanner.Application.Authentication.Common;
using MediatR;

namespace EventPlanner.Application.Authentication.Queries.Login
{
    public record LoginQuery(
        string Email,
        string Password) : IRequest<ErrorOr<AuthenticationResult>>;
}