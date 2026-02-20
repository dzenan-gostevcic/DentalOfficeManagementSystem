using AutoMapper;
using MedicoDent.Application.Abstractions;
using MedicoDent.Application.DTOs;
using MedicoDent.Application.Filters;
using MedicoDent.Application.Paging;
using MedicoDent.Domain.Entities;

namespace MedicoDent.Application.Services
{
    public class PatientService
    {
        private readonly IPacijentRepository _repo;
        private readonly IMapper _mapper;

        public PatientService(IPacijentRepository repo, IMapper mapper)
        {
            _repo = repo;
            _mapper = mapper;
        }

        public async Task<List<PacijentDto>> GetAllAsync(CancellationToken ct = default)
        {
            var entities = await _repo.GetAllAsync(ct);
            return _mapper.Map<List<PacijentDto>>(entities);
        }

        public async Task<PacijentDto?> GetByIdAsync(int id, CancellationToken ct = default)
        {
            var entity = await _repo.GetByIdAsync(id, ct);
            return entity is null ? null : _mapper.Map<PacijentDto>(entity);
        }

        public async Task<PagedResult<PacijentListItemDto>> SearchAsync(PacijentSearchFilter filter, CancellationToken ct = default)
        {
            var page = await _repo.SearchAsync(filter, ct);

            return new PagedResult<PacijentListItemDto>
            {
                Items = _mapper.Map<List<PacijentListItemDto>>(page.Items),
                TotalCount = page.TotalCount,
                Page = page.Page,
                PageSize = page.PageSize
            };
        }

        public async Task<int> CreateAsync(CreatePacijentDto dto, CancellationToken ct = default)
        {
            var entity = _mapper.Map<Patient>(dto);

            await _repo.AddAsync(entity, ct);
            await _repo.SaveChangesAsync(ct);

            return entity.Id;
        }

        public async Task<bool> UpdateAsync(UpdatePacijentDto dto, CancellationToken ct = default)
        {
            var entity = await _repo.GetByIdAsync(dto.Id, ct);
            if (entity is null) return false;

            _mapper.Map(dto, entity);

            _repo.Update(entity);
            await _repo.SaveChangesAsync(ct);
            return true;
        }

        public async Task<bool> DeleteAsync(int id, CancellationToken ct = default)
        {
            var entity = await _repo.GetByIdAsync(id, ct);
            if (entity is null) return false;

            entity.IsDeleted = true;
            entity.DeleteDate = DateTime.UtcNow;
            _repo.Update(entity);
            await _repo.SaveChangesAsync(ct);
            return true;
        }
    }
}
