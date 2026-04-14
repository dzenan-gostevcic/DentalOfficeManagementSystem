using AutoMapper;
using MedicoDent.Application.Abstractions;
using MedicoDent.Application.DTOs.Allergie;
using MedicoDent.Domain.Entities;

namespace MedicoDent.Application.Services
{
    public class AllergieService
    {
        private readonly IAllergieRepository _repo;
        private readonly IMapper _mapper;

        public AllergieService(IAllergieRepository repo, IMapper mapper)
        {
            _repo = repo;
            _mapper = mapper;
        }

        public async Task<List<AllergieDto>> GetAllergies(CancellationToken ct = default)
        {
            var entities = await _repo.GetAllAsync(ct);
            return _mapper.Map<List<AllergieDto>>(entities);
        }

        public async Task<List<PatientAllergieDto>> GetAllergiesByPatientId(int patientId)
        {
            var entities = await _repo.GetAllergiesByPatientId(patientId);
            return _mapper.Map<List<PatientAllergieDto>>(entities);
        }

        public async Task AddPatientAllergy(int patientId, int allergyId, string? note)
        {
            var existing = await _repo.GetPatientAllergy(patientId, allergyId);

            if (existing != null)
                return;

            var entity = new PatientAllergies
            {
                PatientId = patientId,
                AllergieId = allergyId,
                AdditionalNote = note
            };

            await _repo.AddPatientAllergieAsync(entity);
            await _repo.SaveChangesAsync();
        }

        public async Task RemovePatientAllergy(int patientId, int allergyId)
        {
            var entity = await _repo.GetPatientAllergy(patientId, allergyId);

            if (entity == null)
                return;

            _repo.RemovePatientAllergie(entity);
            await _repo.SaveChangesAsync();
        }

        public async Task UpdatePatientAllergyNote(int patientId, int allergyId, string? note)
        {
            var entity = await _repo.GetPatientAllergy(patientId, allergyId);

            if (entity == null)
                return;

            entity.AdditionalNote = note;

            await _repo.SaveChangesAsync();
        }
    }
}