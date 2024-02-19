using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using SistemaGestion.DataTransfer;
using SistemaGestion.Services;

namespace SistemaGestion.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductoController : Controller
    {
        private readonly ProductoService _productoService;
        private readonly IMapper _mapper;

        public ProductoController(ProductoService productoService, IMapper mapper)
        {
            this._productoService = productoService;
            this._mapper = mapper;
        }

        [HttpGet("{idUsuario}")]
        public IEnumerable<ProductoData> ObtenerProductosPorUsuario(int idUsuario)
        {
            var productos = this._productoService.ObtenerProductosPorUsuario(idUsuario);

            return _mapper.Map<IEnumerable<ProductoData>>(productos);
        }

        [HttpPost]
        public IActionResult AgregarNuevoProducto([FromBody]ProductoData nuevoProducto)
        {
           return  this._productoService.CrearProducto(nuevoProducto) ? base.Ok(new { mensaje = "Producto agregado", nuevoProducto }) :
                                                                        base.Conflict(new { mensaje = "No se pudo agregar el Producto" });
        }

        [HttpPut]
        public IActionResult ActualizarProducto([FromBody] ProductoData nuevoProducto)
        {
            return this._productoService.ModificarProducto(nuevoProducto) ? base.Ok(new { mensaje = "Producto modificado", nuevoProducto }) :
                                                                            base.Conflict(new { mensaje = "No se pudo modificar el Producto" });
        }

        [HttpDelete("{idProducto}")]
        public IActionResult EliminarProducto(int idProducto)
        {
            return this._productoService.EliminarProductoPorId(idProducto) ? base.Ok(new { mensaje = "Producto eliminado correctamente" }) :
                                                                            base.Conflict(new { mensaje = "No se pudo eliminar el Producto" });
        }
    }
}
