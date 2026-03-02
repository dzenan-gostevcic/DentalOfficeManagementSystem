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

            CreateMap<Patient, PacijentListItemDto>()
                .ForMember(dest => dest.FirstName,
                    opt => opt.MapFrom(src =>
                        src.PatientBasicInfo != null ? src.PatientBasicInfo.FirstName : ""))

                .ForMember(dest => dest.LastName,
                    opt => opt.MapFrom(src =>
                        src.PatientBasicInfo != null ? src.PatientBasicInfo.LastName : ""))

                .ForMember(dest => dest.Phone,
                    opt => opt.MapFrom(src =>
                        src.PatientContact != null ? src.PatientContact.PhoneNumber : ""));

        }
    }
}