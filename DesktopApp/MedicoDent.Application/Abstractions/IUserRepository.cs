using MedicoDent.Domain.Entities;

namespace MedicoDent.Application.Abstractions
{
    public interface IUserRepository
    {
        Task<User?> GetByIdAsync(int id, CancellationToken ct = default);
        Task<User?> GetByUsernameAsync(string username, CancellationToken ct = default);
    }
}
