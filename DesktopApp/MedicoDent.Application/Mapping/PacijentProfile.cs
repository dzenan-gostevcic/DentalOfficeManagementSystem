using AutoMapper;
using MedicoDent.Application.DTOs;
using MedicoDent.Domain.Entities;

namespace MedicoDent.Application.Mapping
{
    public class PacijentProfile : Profile
    {
        public PacijentProfile()
        {
            CreateMap<Patient, PacijentDto>().ReverseMap();
            CreateMap<Patient, PacijentListItemDto>();
        }
    }
}
