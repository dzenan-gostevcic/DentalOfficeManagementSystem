using MedicoDent.Application.Filters;
using MedicoDent.Application.Paging;
using MedicoDent.Domain.Entities;

namespace MedicoDent.Application.Abstractions
{
    public interface IPacijentRepository
    {
        Task<List<Patient>> GetAllAsync(CancellationToken ct = default);
        Task<Patient?> GetByIdAsync(int id, CancellationToken ct = default);
        Task<PagedResult<Patient>> SearchAsync(PacijentSearchFilter filter, CancellationToken ct = default);
    
        Task AddAsync(Patient pacijent, CancellationToken ct = default);
        void Update(Patient pacijent);
        void Remove(Patient pacijent);

        Task SaveChangesAsync(CancellationToken ct = default);
    }
}
