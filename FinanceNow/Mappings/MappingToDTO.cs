using AutoMapper;
using FinanceNow.Entities;
using FinanceNow.Entities.DTO;

namespace FinanceNow.Mappings
{
    public class MappingToDTO : Profile
    {
        public MappingToDTO()
        {
            CreateMap<Usuario, UsuarioResponseDTO>();
            CreateMap<UsuarioCreateDTO, Usuario>();
        }
    }
}
