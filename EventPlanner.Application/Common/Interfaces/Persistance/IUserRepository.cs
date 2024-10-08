using EventPlanner.Domain.Entities;

namespace EventPlanner.Application.Common.Interfaces.Persistance;

public interface IUserRepository
{
    User? GetUserByEmail(string email);
    void Add(User user);
}