using AutoMapper;
using MedicoDent.Application.DTOs;
using MedicoDent.Domain.Entities;

namespace MedicoDent.Application.Mapping
{
    public class PacijentProfile : Profile
    {
        public PacijentProfile()
        {
            // -----------------------------
            // BASIC INFO
            // -----------------------------
            CreateMap<PatientBasicInfo, PacijentDto>();
            CreateMap<CreatePacijentDto, PatientBasicInfo>();
            CreateMap<UpdatePacijentDto, PatientBasicInfo>();


            // -----------------------------
            // CONTACT INFO
            // -----------------------------
            CreateMap<PatientContact, PacijentDto>();
            CreateMap<CreatePacijentDto, PatientContact>();
            CreateMap<UpdatePacijentDto, PatientContact>();


            // -----------------------------
            // PATIENT -> DTO
            // -----------------------------
            CreateMap<Patient, PacijentDto>()
                .IncludeMembers(s => s.PatientBasicInfo, s => s.PatientContact);


            // -----------------------------
            // PATIENT LIST ITEM
            // -----------------------------
            CreateMap<Patient, PacijentListItemDto>()
                .ForMember(dest => dest.FirstName, opt => opt.MapFrom(src => src.PatientBasicInfo.FirstName))
                .ForMember(dest => dest.LastName, opt => opt.MapFrom(src => src.PatientBasicInfo.LastName))
                .ForMember(dest => dest.Phone, opt => opt.MapFrom(src => src.PatientContact.PhoneNumber))
                .ForMember(dest => dest.Email, opt => opt.MapFrom(src => src.PatientContact.Email))
                .ForMember(dest=> dest.BirthDate, opt=> opt.MapFrom(src => src.PatientBasicInfo.BirthDate))
                ;
            

            // -----------------------------
            // CREATE PATIENT
            // -----------------------------
            CreateMap<CreatePacijentDto, Patient>()
                .ForMember(dest => dest.PatientBasicInfo,
                    opt => opt.MapFrom(src => src))
                .ForMember(dest => dest.PatientContact,
                    opt => opt.MapFrom(src => src));


            // -----------------------------
            // UPDATE PATIENT
            // -----------------------------
            CreateMap<UpdatePacijentDto, Patient>()
                .ForMember(dest => dest.PatientBasicInfo,
                    opt => opt.MapFrom(src => src))
                .ForMember(dest => dest.PatientContact,
                    opt => opt.MapFrom(src => src));
        }
    }
}