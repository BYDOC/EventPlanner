using ErrorOr;
using EventPlanner.Application.Authentication.Common;
using MediatR;

namespace EventPlanner.Application.Authentication.Commands.Register
{
    public record RegisterCommand(
        string FirstName,
        string LastName,
        string Email,
        string Password):IRequest<ErrorOr<AuthenticationResult>>;
}