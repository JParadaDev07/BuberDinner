using BuberDinner.Domain.Entities;

namespace BuberDinner.Application.Common.Interfaces.Persistence;

public interface IUserRepository
{
    Task<User> GetByEmailAsync(string email, CancellationToken cancellationToken = default);
    Task<User> GetByIdAsync(Guid id, CancellationToken cancellationToken = default);
    Task<User> AddAsync(User user, CancellationToken cancellationToken = default);
    Task<User> UpdateAsync(User user, CancellationToken cancellationToken = default);
    Task<User> DeleteAsync(User user, CancellationToken cancellationToken = default);
}