using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using SistemaGestion.DataTransfer;
using SistemaGestion.Services;

namespace SistemaGestion.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductoVendidoController : Controller
    {
        private readonly ProductoVendidoservice _productoVendidoservice;
        private readonly IMapper _mapper;

        public ProductoVendidoController(ProductoVendidoservice productoVendidoService, IMapper mapper)
        {
            this._productoVendidoservice = productoVendidoService;
            this._mapper = mapper;
        }

        [HttpGet("{idUsuario}")]
        public IEnumerable<ProductoVendidoData> obtenerProductoVendidosPorUsuario(int idUsuario)
        {
           var result = this._productoVendidoservice.obtenerProductoVendidosPorUsuario(idUsuario);

           return this._mapper.Map<IEnumerable<ProductoVendidoData>>(result);
        }
    }
}
