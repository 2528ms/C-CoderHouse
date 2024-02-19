using SistemaGestion.Database;
using SistemaGestion.Models;
using Microsoft.EntityFrameworkCore;
using AutoMapper;

namespace SistemaGestion.Services
{
    public class ProductoVendidoservice
    {
        private readonly DataBaseContext _context;
        private readonly IMapper _mapper;
        private readonly ProductoService _productoService;

        public ProductoVendidoservice(DataBaseContext DbContext, IMapper mapper, ProductoService productoService)
        {
            this._context = DbContext;
            this._mapper = mapper;
            this._productoService = productoService;
        }

        public ProductoVendido ObtenerProductoVendidoporId(int id)
        {
            try
            {
                    ProductoVendido? productoVendido = this._context.ProductoVendidos.Where(p => p.Id == id).FirstOrDefault();

                    if (productoVendido == null)
                    {
                        throw new Exception("No se pudo obtener ningun ProductoVendido con ese Id");
                    }

                    return productoVendido;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener el ProductoVendido", ex);
            }
        }

        public List<ProductoVendido> ListarProductoVendidos()
        {
            try
            {
                    List<ProductoVendido> productosVendidos = this._context.ProductoVendidos.ToList();

                    return productosVendidos;
            }
            catch (Exception ex)
            {
                throw new Exception("Ocurrio un error al obtener todos los productosVendidos", ex);
            }
        }

        public bool CrearProductoVendido(ProductoVendido nuevoProductoVendido)
        {
            try
            {
                this._context.ProductoVendidos.Add(nuevoProductoVendido);
                this._context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("Ocurrio un error al crear el ProductoVendido", ex);
            }
        }

        public bool ModificarProductoVendidoPorId(ProductoVendido productonModificado, int id)
        {
            try
            {
                ProductoVendido productoVendidoBuscado = ObtenerProductoVendidoporId(id);
                if (productoVendidoBuscado is not null)
                {
                        productoVendidoBuscado.Stock = productonModificado.Stock;
                        productoVendidoBuscado.IdProducto = productonModificado.IdProducto;
                        productoVendidoBuscado.IdVenta = productonModificado.IdVenta;

                        this._context.ProductoVendidos.Update(productoVendidoBuscado);
                        this._context.SaveChanges();
                        return true;
                }
                return false;
            }
            catch (Exception ex)
            {
                throw new Exception("Ocurrio un error al modificar el ProductoVendido", ex);
            }
        }

        public bool EliminarProductoVendidoPorId(int id)
        {
            try
            {
                ProductoVendido? productoVendidoAEliminar = this._context.ProductoVendidos
                                .Include(x => x.IdVentaNavigation)
                                .Include(x => x.IdProductoNavigation)
                                .Where(p => p.Id == id).FirstOrDefault();

                if (productoVendidoAEliminar is not null)
                {
                    this._context.ProductoVendidos.Remove(productoVendidoAEliminar);
                    this._context.SaveChanges();
                    return true;
                }
                return false;
            }
            catch (Exception ex)
            {
                throw new Exception("Ocurrio un error al eliminar un ProductoVendido", ex);
            }
        }

        public List<ProductoVendido> obtenerProductoVendidosPorUsuario(int idUsuario)
        {
            List<ProductoVendido> productosVendidos = this.ListarProductoVendidos();
            //Obtenemos todos los productos del usuario y luego solo filtramos los Ids de cada producto
            var productosPorUsuario = this._productoService.ObtenerProductosPorUsuario(idUsuario)
                                                            .Select(producto => producto.Id).ToList();
            //Filtramos todos los productos ventidos por los ids obtenidos en el paso anterios
            var productosVendidosFiltrados = productosVendidos.Where(pv => productosPorUsuario.Contains(pv.IdProducto)).ToList();

            return productosVendidosFiltrados;
        }
    }
}
