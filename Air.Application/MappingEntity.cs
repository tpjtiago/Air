using Air.Application.DTO;
using Air.Domain.Entities;
using AutoMapper;

namespace Air.Application
{
    public class MappingEntity : Profile
    {
        public MappingEntity()
        {

            CreateMap<ClienteDTO, Cliente>().ReverseMap();

        }
    }
}
