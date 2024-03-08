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
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
                .ForMember(dest => dest.Nombre, opt => opt.MapFrom(src => src.Nombre))
                .ForMember(dest => dest.Apellido, opt => opt.MapFrom(src => src.Apellido))
                .ForMember(dest => dest.NombreUsuario, opt => opt.MapFrom(src => src.NombreUsuario))
                .ForMember(dest => dest.Contraseña, opt => opt.MapFrom(src => src.Contraseña))
                .ForMember(dest => dest.Mail, opt => opt.MapFrom(src => src.Mail));

            CreateMap<UsuarioData, Usuario>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
                .ForMember(dest => dest.Nombre, opt => opt.MapFrom(src => src.Nombre))
                .ForMember(dest => dest.Apellido, opt => opt.MapFrom(src => src.Apellido))
                .ForMember(dest => dest.NombreUsuario, opt => opt.MapFrom(src => src.NombreUsuario))
                .ForMember(dest => dest.Contraseña, opt => opt.MapFrom(src => src.Contraseña))
                .ForMember(dest => dest.Mail, opt => opt.MapFrom(src => src.Mail));

            CreateMap<Producto, ProductoData>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
                .ForMember(dest => dest.Descripciones, opt => opt.MapFrom(src => src.Descripciones))
                .ForMember(dest => dest.Costo, opt => opt.MapFrom(src => src.Costo))
                .ForMember(dest => dest.PrecioVenta, opt => opt.MapFrom(src => src.PrecioVenta))
                .ForMember(dest => dest.Stock, opt => opt.MapFrom(src => src.Stock))
                .ForMember(dest => dest.IdUsuario, opt => opt.MapFrom(src => src.IdUsuario));

            CreateMap<ProductoData, Producto>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
                .ForMember(dest => dest.Descripciones, opt => opt.MapFrom(src => src.Descripciones))
                .ForMember(dest => dest.Costo, opt => opt.MapFrom(src => src.Costo))
                .ForMember(dest => dest.PrecioVenta, opt => opt.MapFrom(src => src.PrecioVenta))
                .ForMember(dest => dest.Stock, opt => opt.MapFrom(src => src.Stock))
                .ForMember(dest => dest.IdUsuario, opt => opt.MapFrom(src => src.IdUsuario));

            CreateMap<Venta,VentaData>()
                .ForMember(dest => dest.id, opt => opt.MapFrom(src => src.Id))
                .ForMember(dest => dest.Comentario, opt => opt.MapFrom(src => src.Comentarios));

            CreateMap<VentaData, Venta>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.id))
                .ForMember(dest => dest.Comentarios, opt => opt.MapFrom(src => src.Comentario))
                .ForMember(dest => dest.IdUsuario, opt => opt.MapFrom(src => src.IdUsuario));

            CreateMap<ProductoVendido, ProductoVendidoData>()
               .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
               .ForMember(dest => dest.IdProducto, opt => opt.MapFrom(src => src.IdProducto))
               .ForMember(dest => dest.Stock, opt => opt.MapFrom(src => src.Stock))
               .ForMember(dest => dest.IdVenta, opt => opt.MapFrom(src => src.IdVenta));
        }
    }
}
