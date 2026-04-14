using AutoMapper;
using MedicoDent.Application.DTOs.Allergie;
using MedicoDent.Domain.Entities;

namespace MedicoDent.Application.Mapping
{
    public class AllergieProfile : Profile
    {
        public AllergieProfile()
        {
            CreateMap<Allergie, AllergieDto>();
            CreateMap<PatientAllergies, PatientAllergieDto>().ForMember(dest => dest.AllergieName, opt => opt.MapFrom(src => src.Allergie.Name));
        }
    }
}