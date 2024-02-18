using SistemaGestion.Database;
using SistemaGestion.Models;
using Microsoft.EntityFrameworkCore;

namespace SistemaGestion.Services
{
    public class ProductoService
    {
        private readonly DataBaseContext context;

        public ProductoService(DataBaseContext DbContext)
        {
            this.context = DbContext;
        }

        public Producto ObtenerProductoPorId(int id)
        {
            try
            {
                    Producto producto = context.Producto.Where(p => p.Id == id).FirstOrDefault();

                    if (producto == null)
                    {
                        throw new Exception("No se pudo obtener ningun Producto con ese Id");
                    }
                    return producto;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener el Producto", ex);
            }
        }

        public List<Producto> ObtenerProductoPorUsuario(int idUsuario)
        {
            try
            {               
                var producto = context.Producto.Where(p => p.IdUsuario == idUsuario).ToList() ??
                                    throw new Exception("No se pudo obtener ningun Producto con ese Id");
 
                return producto;
                
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener el Producto", ex);
            }
        }

        public List<Producto> ListarProductos()
        {
            try
            {
                    List<Producto> productos = context.Producto.ToList();

                    return productos;
            }
            catch (Exception ex)
            {
                throw new Exception("Ocurrio un error al obtener todos los productos", ex);
            }
        }

        public bool CrearProducto(Producto nuevoProducto)
        {
            try
            {
                    context.Producto.Add(nuevoProducto);
                    context.SaveChanges();
                    return true;
            }
            catch (Exception ex)
            {
                throw new Exception("Ocurrio un error al crear el Producto", ex);
            }
        }

        public bool ModificarProductoPorId(Producto producto, int id)
        {
            try
            {
                Producto productoBuscado = ObtenerProductoPorId(id);
                if (productoBuscado is not null)
                {
                        productoBuscado.Descripciones = producto.Descripciones;
                        productoBuscado.Costo = producto.Costo;
                        productoBuscado.PrecioVenta = producto.PrecioVenta;
                        productoBuscado.Stock = producto.Stock;
                        productoBuscado.IdUsuario = producto.IdUsuario;

                        context.Producto.Update(productoBuscado);
                        context.SaveChanges();
                        return true;
                }
                return false;
            }
            catch (Exception ex)
            {
                throw new Exception("Ocurrio un error al modificar el Usuario", ex);
            }
        }

        public bool EliminarProductoPorId(int id)
        {
            try
            {
                    Producto productoAEliminar = context.Producto.Include(p => p.ProductoVendidos).Where(p => p.Id == id).FirstOrDefault();

                    if (productoAEliminar is not null)
                    {
                        context.Producto.Remove(productoAEliminar);
                        context.SaveChanges();
                        return true;
                    }
                return false;
            }
            catch (Exception ex)
            {
                throw new Exception("Ocurrio un error al eliminar un Producto", ex);
            }
        }
    }
}
