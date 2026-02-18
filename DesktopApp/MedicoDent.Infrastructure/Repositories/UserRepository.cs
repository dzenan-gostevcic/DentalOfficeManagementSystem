using MedicoDent.Application.Abstractions;
using MedicoDent.Domain.Entities;
using MedicoDent.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;

namespace MedicoDent.Infrastructure.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly AppDbContext _db;

        public UserRepository(AppDbContext db) { _db = db; }

        public Task<User?> GetByIdAsync(int id, CancellationToken ct = default)
            => _db.Users
                .FirstOrDefaultAsync(u => u.Id == id, ct);

        public Task<User?> GetByUsernameAsync(string username, CancellationToken ct = default)
            => _db.Users
                .FirstOrDefaultAsync(u => !string.IsNullOrEmpty(u.Username) && u.Username.Equals(username), ct);
    }
}
