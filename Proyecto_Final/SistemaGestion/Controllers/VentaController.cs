using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using SistemaGestion.DataTransfer;
using SistemaGestion.Services;
using System.Collections.Generic;

namespace SistemaGestion.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class VentaController : Controller
    {
        private readonly VentaService _ventaService;
        private readonly IMapper _mapper;

        public VentaController(VentaService ventaService, IMapper mapper)
        {
            _ventaService = ventaService;
            _mapper = mapper;
        }

        [HttpGet("{idUsuario}")]
        public IEnumerable<VentaData> ObtenerVentasPorUsuario(int idUsuario)
        {
            var ventas = _ventaService.ObtenerVentaPorIdUsuario(idUsuario);

            return _mapper.Map<IEnumerable<VentaData>>(ventas);
        }

        [HttpPost("{idUsuario}")]
        public IActionResult AgregarNuevaVenta(int idUsuario, [FromBody] List<ProductoData> productos)
        {
            return this._ventaService.CrearVenta(idUsuario, productos) ? base.Ok(new { mensaje = "Venta creada exitosamente"}) :
                                                               base.Conflict(new { mensaje = "No se pudo agregar la Venta" });
        }
    }
}
