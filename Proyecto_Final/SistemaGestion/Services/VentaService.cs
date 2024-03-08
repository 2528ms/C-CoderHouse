using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using SistemaGestion.Database;
using SistemaGestion.DataTransfer;
using SistemaGestion.Models;

namespace SistemaGestion.Services
{
    public class VentaService
    {
        private readonly DataBaseContext context;
        private readonly IMapper _mapper;
        private readonly ProductoVendidoservice _productoVendidoService;
        private readonly ProductoService _productoService;

        public VentaService(DataBaseContext DbContext, IMapper mapper, ProductoVendidoservice productoVendidoService, ProductoService productoService)
        {
            this.context = DbContext;
            _mapper = mapper;
            this._productoVendidoService = productoVendidoService;
            this._productoService = productoService;
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

        public bool CrearVenta(int idUsuario, List<ProductoData> productos)
        {
            try
            {
                Venta venta = new Venta();
                List<string?> descripciones = productos.Select(x => x.Descripciones).ToList();
                string comentario = string.Join("-", descripciones);
                venta.Comentarios = comentario;
                venta.IdUsuario = idUsuario;

                context.Venta.Add(venta);
                context.SaveChanges();

                this.cargarProductosVendidos(productos, venta.Id);
                this.ActualizarStockProductosVendidos(productos);
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

        private void cargarProductosVendidos(List<ProductoData> productos, int idVenta)
        {
            foreach (var p in productos)
            {
                ProductoVendido productoVendido = new ProductoVendido();
                productoVendido.IdProducto = p.Id;
                productoVendido.IdVenta = idVenta;
                productoVendido.Stock = p.Stock;

                this._productoVendidoService.CrearProductoVendido(productoVendido);
            }
        }

        private void ActualizarStockProductosVendidos(List<ProductoData> productos)
        {
            productos.ForEach(producto => {
                ProductoData productoActual = _mapper.Map<ProductoData>(this._productoService.ObtenerProductoPorId(producto.Id)); 
                productoActual.Stock -= producto.Stock;
                this._productoService.ActualizarStockProducto(productoActual);            
            });
        }
    }
}
