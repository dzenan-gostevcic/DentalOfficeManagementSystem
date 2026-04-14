using MedicoDent.Application.Abstractions;
using MedicoDent.Domain.Entities;
using MedicoDent.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;

namespace MedicoDent.Infrastructure.Repositories
{
    public class AllergieRepository : IAllergieRepository
    {
        private readonly AppDbContext _db;

        public AllergieRepository(AppDbContext db) => _db = db;

        // Allergie CRUD
        public Task<List<Allergie>> GetAllAsync(CancellationToken ct)
            => _db.Allergies.AsNoTracking().OrderBy(a => a.Name).ToListAsync(ct);

        public Task<Allergie?> GetByIdAsync(int id)
            => _db.Allergies.AsNoTracking().FirstOrDefaultAsync(a => a.Id == id);

        public Task AddAsync(Allergie allergie, CancellationToken ct = default)
            => _db.Allergies.AddAsync(allergie, ct).AsTask();

        public void Update(Allergie allergie)
            => _db.Allergies.Update(allergie);

        public void Remove(Allergie allergie)
            => _db.Allergies.Remove(allergie);


        // PatientAllergies
        public Task<List<PatientAllergies>> GetAllergiesByPatientId(int patientId)
            => _db.PatientAllergies.Include(pa => pa.Allergie).Where(pa => pa.PatientId == patientId).ToListAsync();

        public Task<PatientAllergies?> GetPatientAllergy(int patientId, int allergyId)
            => _db.PatientAllergies.FirstOrDefaultAsync(a => a.PatientId == patientId && a.AllergieId == allergyId);

        public Task AddPatientAllergieAsync(PatientAllergies patientAllergie, CancellationToken ct = default)
            => _db.PatientAllergies.AddAsync(patientAllergie, ct).AsTask();

        public void RemovePatientAllergie(PatientAllergies patientAllergie)
            => _db.PatientAllergies.Remove(patientAllergie);


        public Task SaveChangesAsync(CancellationToken ct = default)
            => _db.SaveChangesAsync(ct);
    }
}