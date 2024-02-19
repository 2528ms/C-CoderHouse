using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using SistemaGestion.DataTransfer;
using SistemaGestion.Models;
using SistemaGestion.Services;

namespace SistemaGestion.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UsuarioController : Controller
    {
        private readonly UsuarioService _usuarioService;
        private readonly IMapper _mapper;

        public UsuarioController(UsuarioService usuarioService, IMapper mapper)
        {
            this._usuarioService = usuarioService;
            this._mapper = mapper;
        }

        [HttpGet("Usuarios")]
        public IEnumerable<UsuarioData> ListadoDeUsuarios()
        {
            var usuario = this._usuarioService.ListarUsuarios();
            
            return _mapper.Map<IEnumerable<UsuarioData>>(usuario);
        }

        [HttpGet("{nombreUsuario}")]
        public UsuarioData ObtenerUsuarioPorNombreUsuario(string nombreUsuario)
        {
            var usuario = this._usuarioService.ObtenerUsuarioPorNombreUsuario(nombreUsuario);

            return _mapper.Map<UsuarioData>(usuario);
        }

        [HttpGet("{usuario}/{passwork}")]
        public UsuarioData ObtenerUsuario(string usuario, string passwork)
        {
            var result = this._usuarioService.ObtenerUsuario(usuario, passwork);

            return _mapper.Map<UsuarioData>(result);
        }

        [HttpPost]
        public IActionResult AgregarNuevoUsuario([FromBody] UsuarioData nuevoUsuario)
        {
            return this._usuarioService.CrearUsuario(nuevoUsuario) ? base.Ok(new { mensaje = "Usuario agregado", nuevoUsuario }) :
                                                                     base.Conflict(new { mensaje = "No se pudo agregar el Usuario" });
        }

        [HttpPut]
        public IActionResult ActualizarUsuario([FromBody] UsuarioData nuevoUsuario)
        {
            return this._usuarioService.ModificarUsuario(nuevoUsuario) ? base.Ok(new { mensaje = "Usuario actualizado", nuevoUsuario }) :
                                                                         base.Conflict(new { mensaje = "No se pudo actualizar el Usuario" });
        }
    }
}
