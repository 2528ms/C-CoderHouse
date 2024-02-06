using DataAccess.DataBase;
using DataAccess.Models;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Services
{
    public static class ProductoVendidoData
    {
        public static ProductoVendido ObtenerProductoVendidoporId(int id)
        {
            try
            {
                using (DataBaseContext context = new DataBaseContext())
                {
                    ProductoVendido productoVendido = context.ProductoVendidos.Where(p => p.Id == id).FirstOrDefault();

                    if (productoVendido == null)
                    {
                        throw new Exception("No se pudo obtener ningun ProductoVendido con ese Id");
                    }

                    return productoVendido;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener el ProductoVendido", ex);
            }          
        }

        public static List<ProductoVendido> ListarProductoVendidos()
        {
            try
            {
                using (DataBaseContext context = new DataBaseContext())
                {
                    List<ProductoVendido> productosVendidos = context.ProductoVendidos.ToList();

                    return productosVendidos;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Ocurrio un error al obtener todos los productosVendidos", ex);
            }
        }

        public static bool CrearProductoVendido(ProductoVendido nuevoProductoVendido)
        {
            try
            {
                using (DataBaseContext context = new DataBaseContext())
                {
                    context.ProductoVendidos.Add(nuevoProductoVendido);
                    context.SaveChanges();
                    return true;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Ocurrio un error al crear el ProductoVendido", ex);
            }
        }

        public static bool ModificarProductoVendidoPorId(ProductoVendido productonModificado, int id)
        {
            try
            {                
                ProductoVendido productoVendidoBuscado = ObtenerProductoVendidoporId(id);
                if (productoVendidoBuscado is not null)
                {
                    using (DataBaseContext context = new DataBaseContext())
                    {
                        productoVendidoBuscado.Stock = productonModificado.Stock;
                        productoVendidoBuscado.IdProducto = productonModificado.IdProducto;
                        productoVendidoBuscado.IdVenta = productonModificado.IdVenta;

                        context.ProductoVendidos.Update(productoVendidoBuscado);
                        context.SaveChanges();
                        return true;
                    }
                }
                return false;
            }
            catch (Exception ex)
            {
                throw new Exception("Ocurrio un error al modificar el ProductoVendido", ex);
            }
        }

        public static bool EliminarProductoVendidoPorId(int id)
        {
            try
            {
                using (DataBaseContext context = new DataBaseContext())
                {
                    ProductoVendido productoVendidoAEliminar = context.ProductoVendidos
                                    .Include(x => x.IdVentaNavigation)
                                    .Include(x => x.IdProductoNavigation)
                                    .Where(p => p.Id == id).FirstOrDefault();

                    if (productoVendidoAEliminar is not null)
                    {
                        context.ProductoVendidos.Remove(productoVendidoAEliminar);
                        context.SaveChanges();
                        return true;
                    }
                }
                return false;
            }
            catch (Exception ex)
            {
                throw new Exception("Ocurrio un error al eliminar un ProductoVendido", ex);
            }
        }
    }
}
