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
            var productos = this._productoService.ObtenerProductoPorUsuario(idUsuario);

            return _mapper.Map<IEnumerable<ProductoData>>(productos);
        }
    }
}