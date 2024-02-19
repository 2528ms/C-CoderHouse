using SistemaGestion.Database;
using SistemaGestion.Models;
using SistemaGestion.DataTransfer;
using AutoMapper;

namespace SistemaGestion.Services
{
    public class ProductoService
    {
        private readonly DataBaseContext context;
        private readonly IMapper mapper;

        public ProductoService(DataBaseContext DbContext, IMapper mapper)
        {
            this.context = DbContext;
            this.mapper = mapper;
        }

        public Producto ObtenerProductoPorId(int id)
        {
            try
            {
                Producto producto = context.Producto.Where(p => p.Id == id).FirstOrDefault()??
                                    throw new Exception("No se pudo obtener ningun Producto con ese Id");
    
                return producto;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener el Producto", ex);
            }
        }

        public List<Producto> ObtenerProductosPorUsuario(int idUsuario)
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

        public bool CrearProducto(ProductoData nuevoProducto)
        {
            try
            {   var result = mapper.Map<Producto>(nuevoProducto);
                context.Producto.Add(result);
                context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("Ocurrio un error al crear el Producto", ex);
            }
        }

        public bool ModificarProducto(ProductoData nuevoProducto)
        {
            try
            {
                Producto productoBuscado = ObtenerProductoPorId(nuevoProducto.Id);
                if (productoBuscado is not null)
                {
                        productoBuscado.Descripciones = nuevoProducto.Descripciones;
                        productoBuscado.Costo = nuevoProducto.Costo;
                        productoBuscado.PrecioVenta = nuevoProducto.PrecioVenta;
                        productoBuscado.Stock = nuevoProducto.Stock;
                        productoBuscado.IdUsuario = nuevoProducto.IdUsuario;

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

        public bool EliminarProductoPorId(int idProducto)
        {
            try
            {
                Producto? productoAEliminar = this.ObtenerProductoPorId(idProducto);

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
