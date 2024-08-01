using AutoMapper;
using ClinicBackend.DTO;
using ClinicBackend.Models;

namespace ClinicBackend.Mapper
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Patient, PatientDTO>();
            CreateMap<PatientDTO, Patient>();
            CreateMap<Contact, ContactDTO>();
            CreateMap<ContactDTO, Contact>();
        }

    }
}
