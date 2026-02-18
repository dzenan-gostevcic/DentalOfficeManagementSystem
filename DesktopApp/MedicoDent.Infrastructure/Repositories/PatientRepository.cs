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

        public async Task<PagedResult<Patient>> SearchAsync(PacijentSearchFilter filter, CancellationToken ct = default)
        {
            var page = filter.Page < 1 ? 1 : filter.Page;
            var pageSize = filter.PageSize < 1 ? 20 : filter.PageSize;
            if (pageSize > 200) pageSize = 200; // for safety 

            IQueryable<Patient> query = _db.Patients.AsNoTracking();

            if (!string.IsNullOrWhiteSpace(filter.Name))
            {
                var term = filter.Name.Trim().ToLower();

                query = query.Include(p => p.PatientBasicInfo).Where(p =>
                    (!string.IsNullOrEmpty(p.PatientBasicInfo.FirstName) && p.PatientBasicInfo.FirstName.ToLower().Contains(term)) ||
                    (!string.IsNullOrEmpty(p.PatientBasicInfo.LastName) && p.PatientBasicInfo.LastName.ToLower().Contains(term))
                );
            }

            var total = await query.CountAsync(ct);

            query = query.
                Include(p => p.PatientBasicInfo)
                .OrderBy(p => p.PatientBasicInfo.LastName)
                .ThenBy(p => p.PatientBasicInfo.FirstName)
                .ThenBy(p => p.Id);

            var items = await query
                .Skip((page - 1) * pageSize)
                .Take(pageSize)
                .ToListAsync(ct);

            var result = new PagedResult<Patient>
            {
                Items = items,
                TotalCount = total,
                Page = page,
                PageSize = pageSize
            };

            return result;
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
