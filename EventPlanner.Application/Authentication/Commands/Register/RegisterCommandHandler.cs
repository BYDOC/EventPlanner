using ErrorOr;
using EventPlanner.Application.Common.Interfaces.Authentication;
using EventPlanner.Application.Common.Interfaces.Persistence;
using MediatR;
using EventPlanner.Domain.Common.Errors;
using EventPlanner.Domain.Entities;
using EventPlanner.Application.Authentication.Common;

namespace EventPlanner.Application.Authentication.Commands.Register
{
    public class RegisterCommandHandler :
    IRequestHandler<RegisterCommand, ErrorOr<AuthenticationResult>>
    {
        private readonly IJwtTokenGenerator _jwtTokenGenerator;
                private readonly IUserRepository _userRepository;


        public RegisterCommandHandler(IJwtTokenGenerator jwtTokenGenerator, IUserRepository userRepository)
        {
            _jwtTokenGenerator = jwtTokenGenerator;
            _userRepository = userRepository;
        }

        public async Task<ErrorOr<AuthenticationResult>> Handle(RegisterCommand command, CancellationToken cancellationToken)
        {
            //validate user doesn't exist
            if (_userRepository.GetUserByEmail(command.Email) != null)
            {
                return Errors.User.DuplicateEmail;
            }

            //create user (generate unique id) & save to db
            var user = new User
            {
                FirstName = command.FirstName,
                LastName = command.LastName,
                Email = command.Email,
                Password = command.Password
            };
            _userRepository.Add(user);
            //generate JWT token  


            var token = _jwtTokenGenerator.GenerateToken(user);

            return new AuthenticationResult(
                user,
                token);
        }
    }

}