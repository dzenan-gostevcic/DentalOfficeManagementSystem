using AutoMapper;
using MedicoDent.Application.DTOs;
using MedicoDent.Domain.Entities;
using System.Xml.Serialization;

namespace MedicoDent.Application.Mapping
{
    public class PacijentProfile : Profile
    {
        public PacijentProfile()
        {
            
            CreateMap<Patient, PacijentDto>()
                .ForMember(dest => dest.FirstName,
                    opt => opt.MapFrom(src => src.PatientBasicInfo.FirstName))
                .ForMember(dest => dest.LastName,
                    opt => opt.MapFrom(src => src.PatientBasicInfo.LastName))
                .ForMember(dest => dest.Phone,
                    opt => opt.MapFrom(src => src.PatientContact.PhoneNumber));

            CreateMap<Patient, PacijentListItemDto>()
                .ForMember(dest => dest.FirstName,
                    opt => opt.MapFrom(src => src.PatientBasicInfo.FirstName))
                .ForMember(dest => dest.LastName,
                    opt => opt.MapFrom(src => src.PatientBasicInfo.LastName))
                .ForMember(dest => dest.Phone,
                    opt => opt.MapFrom(src => src.PatientContact.PhoneNumber))
                .ForMember(dest => dest.HasAllergie,
                    opt => opt.MapFrom(src => src.HasAllergie))
                    .ForMember(dest => dest.IsBlackListed,
                      opt => opt.MapFrom(src => src.IsBlackListed));



            
                CreateMap<CreatePacijentDto, Patient>()
    .ForMember(dest => dest.HasAllergie,
        opt => opt.MapFrom(src => src.HasAllergie))
    .ForMember(dest => dest.IsBlackListed,
        opt => opt.MapFrom(src => src.IsBlackListed))
    .ForMember(dest => dest.PatientBasicInfo,
        opt => opt.MapFrom(src => new PatientBasicInfo
        {
            FirstName = src.FirstName,
            LastName = src.LastName
        }))
    .ForMember(dest => dest.PatientContact,
        opt => opt.MapFrom(src => new PatientContact
        {
            PhoneNumber = src.Phone
        }));


            CreateMap<UpdatePacijentDto, Patient>()
                .ForMember(dest => dest.HasAllergie,
                     opt => opt.MapFrom(src => src.HasAllergie))
                   .ForMember(dest => dest.IsBlackListed,
                  opt => opt.MapFrom(src => src.IsBlackListed))
                .ForPath(dest => dest.PatientBasicInfo.FirstName,
                    opt => opt.MapFrom(src => src.FirstName))
                .ForPath(dest => dest.PatientBasicInfo.LastName,
                    opt => opt.MapFrom(src => src.LastName))
                .ForPath(dest => dest.PatientContact.PhoneNumber,
                    opt => opt.MapFrom(src => src.Phone));
            
        }
    }
}