using AutoMapper;
using SistemaGestion.DataTransfer;
using SistemaGestion.Models;

namespace SistemaGestion.Database
{
    public class EntityToDtoProfile : Profile
    {
        public EntityToDtoProfile()
        {
            CreateMap<Usuario, UsuarioData>()
                .ForMember(dest => dest.UsuarioId, opt => opt.MapFrom(src => src.Id))
                .ForMember(dest => dest.Nombre, opt => opt.MapFrom(src => src.Nombre))
                .ForMember(dest => dest.Apellido, opt => opt.MapFrom(src => src.Apellido))
                .ForMember(dest => dest.UserName, opt => opt.MapFrom(src => src.NombreUsuario))
                .ForMember(dest => dest.Passwork, opt => opt.MapFrom(src => src.Contraseña))
                .ForMember(dest => dest.Email, opt => opt.MapFrom(src => src.Mail));

            CreateMap<Producto, ProductoData>()
                .ForMember(dest => dest.Descripciones, opt => opt.MapFrom(src => src.Descripciones))
                .ForMember(dest => dest.Costo, opt => opt.MapFrom(src => src.Costo))
                .ForMember(dest => dest.PrecioVenta, opt => opt.MapFrom(src => src.PrecioVenta))
                .ForMember(dest => dest.Stock, opt => opt.MapFrom(src => src.Stock));
        }
    }
}
