using MedicoDent.Domain.Entities;

namespace MedicoDent.Application.Abstractions
{
    public interface IAllergieRepository
    {
        Task<List<Allergie>> GetAllAsync(CancellationToken ct);
        Task<Allergie?> GetByIdAsync(int id);
        Task AddAsync(Allergie allergie, CancellationToken ct = default);
        void Update(Allergie allergie);
        void Remove(Allergie allergie);

        Task<List<PatientAllergies>> GetAllergiesByPatientId(int patientId);
        Task<PatientAllergies?> GetPatientAllergy(int patientId, int allergyId);
        Task AddPatientAllergieAsync(PatientAllergies patientAllergie, CancellationToken ct = default);
        void RemovePatientAllergie(PatientAllergies patientAllergie);

        Task SaveChangesAsync(CancellationToken ct = default);
    }
}