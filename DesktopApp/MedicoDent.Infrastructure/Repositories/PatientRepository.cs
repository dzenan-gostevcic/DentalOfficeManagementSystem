using MedicoDent.Application.Abstractions;
using MedicoDent.Application.Filters;
using MedicoDent.Application.Paging;
using MedicoDent.Domain.Entities;
using MedicoDent.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;

namespace MedicoDent.Infrastructure.Repositories
{
    public class PatientRepository : IPacijentRepository
    {
        private readonly AppDbContext _db;

        public PatientRepository(AppDbContext db)
        {
            _db = db;
        }

        public Task<List<Patient>> GetAllAsync(CancellationToken ct = default)
            => _db.Patients
                .AsNoTracking().
                Include(p => p.PatientBasicInfo)
                .OrderBy(x => x.PatientBasicInfo.LastName)
                .ThenBy(x => x.PatientBasicInfo.FirstName)
                .ToListAsync(ct);

        public Task<Patient?> GetByIdAsync(int id, CancellationToken ct = default)
            => _db.Patients
                .FirstOrDefaultAsync(x => x.Id == id, ct);

        public async Task<PagedResult<Patient>> SearchAsync(
      PacijentSearchFilter filter,
      CancellationToken ct = default)
        {
            var page = filter.Page < 1 ? 1 : filter.Page;
            var pageSize = filter.PageSize < 1 ? 20 : filter.PageSize;
            if (pageSize > 200) pageSize = 200;

            IQueryable<Patient> query = _db.Patients
                .AsNoTracking()
                .Include(p => p.PatientBasicInfo)
                .Include(p => p.PatientContact);

            if (!string.IsNullOrWhiteSpace(filter.SearchTerm))
            {
                var term = filter.SearchTerm.Trim();

                query = query.Where(p =>
                    EF.Functions.Like(p.PatientBasicInfo.FirstName, $"%{term}%") ||
                    EF.Functions.Like(p.PatientBasicInfo.LastName, $"%{term}%") ||
                    EF.Functions.Like(p.PatientContact.PhoneNumber, $"%{term}%")
                );
            }

            var total = await query.CountAsync(ct);

            var items = await query
                .OrderBy(p => p.PatientBasicInfo.LastName)
                .ThenBy(p => p.PatientBasicInfo.FirstName)
                .ThenBy(p => p.Id)
                .Skip((page - 1) * pageSize)
                .Take(pageSize)
                .ToListAsync(ct);

            return new PagedResult<Patient>
            {
                Items = items,
                TotalCount = total,
                Page = page,
                PageSize = pageSize
            };
        }

        public Task AddAsync(Patient pacijent, CancellationToken ct = default)
            => _db.Patients.AddAsync(pacijent, ct).AsTask();

        public void Update(Patient pacijent)
            => _db.Patients.Update(pacijent);

        public void Remove(Patient pacijent)
            => _db.Patients.Remove(pacijent);

        public Task SaveChangesAsync(CancellationToken ct = default)
            => _db.SaveChangesAsync(ct);
    }
}
