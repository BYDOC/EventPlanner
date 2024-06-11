using EventPlanner.Domain.Entities;

namespace EventPlanner.Application.Common.Interfaces.Persistence;

    public interface IUserRepository
    {
        User? GetUserByEmail(string email);
        void Add(User user);
    }
