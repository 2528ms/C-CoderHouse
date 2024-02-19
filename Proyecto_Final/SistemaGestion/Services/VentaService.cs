using AutoMapper;
using SistemaGestion.Database;
using SistemaGestion.DataTransfer;
using SistemaGestion.Models;

namespace SistemaGestion.Services
{
    public class VentaService
    {
        private readonly DataBaseContext context;
        private readonly IMapper _mapper;

        public VentaService(DataBaseContext DbContext, IMapper mapper)
        {
            this.context = DbContext;
            _mapper = mapper;
        }

        public Venta ObtenerVentaPorId(int id)
        {
            try
            {
                Venta venta = context.Venta.Where(p => p.Id == id).FirstOrDefault() ??
                                throw new Exception("No se pudo obtener ninguna Venta con ese Id");

                return venta;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener una Venta", ex);
            }
        }

        public List<Venta> ObtenerVentaPorIdUsuario(int id)
        {
            try
            {
                 List<Venta> ventas = context.Venta.Where(p => p.IdUsuario == id).ToList();

                return ventas;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener una Venta", ex);
            }
        }

        public List<Venta> ListarVentas()
        {
            try
            {
                List<Venta> ventas = context.Venta.ToList();

                return ventas;

            }
            catch (Exception ex)
            {
                throw new Exception("Ocurrio un error al obtener todas las ventas", ex);
            }
        }

        public bool CrearVenta(VentaData nuevaVenta)
        {
            try
            {
                Venta result = this._mapper.Map<Venta>(nuevaVenta);
                context.Venta.Add(result);
                context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("Ocurrio un error al crear la Venta", ex);
            }
        }

        public bool ModificarVentaPorId(Venta venta, int id)
        {
            try
            {
                Venta ventaBuscada = ObtenerVentaPorId(id);
                if (ventaBuscada is not null)
                {
                    ventaBuscada.Comentarios = venta.Comentarios;
                    ventaBuscada.IdUsuario = venta.IdUsuario;

                    context.Venta.Update(ventaBuscada);
                    context.SaveChanges();
                    return true;
                }
                return false;
            }
            catch (Exception ex)
            {
                throw new Exception("Ocurrio un error al modificar la Venta", ex);
            }
        }

        public bool EliminarVentaPorId(int id)
        {
            try
            {
                Venta VentaEliminar = this.ObtenerVentaPorId(id);        

                if (VentaEliminar is not null)
                {
                    context.Venta.Remove(VentaEliminar);
                    context.SaveChanges();
                    return true;
                }
                return false;
            }
            catch (Exception ex)
            {
                throw new Exception("Ocurrio un error al eliminar una Venta", ex);
            }
        }

    }
}
