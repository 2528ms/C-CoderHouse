using SistemaGestion.Database;
using SistemaGestion.Models;

namespace SistemaGestion.Services
{
    public class VentaData
    {
        public Venta ObtenerVentaPorId(int id)
        {
            try
            {
                using (DataBaseContext context = new DataBaseContext())
                {
                    Venta venta = context.Venta.Where(p => p.Id == id).FirstOrDefault();

                    if (venta == null)
                    {
                        throw new Exception("No se pudo obtener ninguna Venta con ese Id");
                    }

                    return venta;
                }
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
                using (DataBaseContext context = new DataBaseContext())
                {
                    List<Venta> ventas = context.Venta.ToList();

                    return ventas;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Ocurrio un error al obtener todas las ventas", ex);
            }
        }

        public bool CrearVenta(Venta nuevaVenta)
        {
            try
            {
                using (DataBaseContext context = new DataBaseContext())
                {
                    context.Venta.Add(nuevaVenta);
                    context.SaveChanges();
                    return true;
                }
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
                    using (DataBaseContext context = new DataBaseContext())
                    {
                        ventaBuscada.Comentarios = venta.Comentarios;
                        ventaBuscada.IdUsuario = venta.IdUsuario;

                        context.Venta.Update(ventaBuscada);
                        context.SaveChanges();
                        return true;
                    }
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
                using (DataBaseContext context = new DataBaseContext())
                {
                    Venta VentaEliminar = context.Venta.Where(p => p.Id == id).FirstOrDefault();

                    if (VentaEliminar is not null)
                    {
                        context.Venta.Remove(VentaEliminar);
                        context.SaveChanges();
                        return true;
                    }
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
