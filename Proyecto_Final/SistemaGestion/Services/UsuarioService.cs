using SistemaGestion.Database;
using SistemaGestion.Models;
using Microsoft.EntityFrameworkCore;
using SistemaGestion.DataTransfer;
using AutoMapper;

namespace SistemaGestion.Services
{
    public class UsuarioService
    {
        private readonly DataBaseContext context;
        private readonly IMapper mapper;

        public UsuarioService(DataBaseContext DbContext, IMapper mapper)
        {
            this.context = DbContext;
            this.mapper = mapper;
        }

        public Usuario ObtenerUsuarioPorId(int id)
        {
            try
            {
                Usuario usuario = context.Usuario.Where(u => u.Id == id).FirstOrDefault() ?? 
                                  throw new Exception("No se pudo obtener ningun Usuario con ese Id");

                return usuario;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener el usuario", ex);
            }
        }

        public Usuario ObtenerUsuarioPorNombreUsuario(string nombreUsurario)
        {
            try
            {   // ?? "operador de asignación nula" si la primera expresion es nula ejecuta o asigna la segunda expresion
                Usuario usuario = context.Usuario.Where(u => u.NombreUsuario == nombreUsurario).FirstOrDefault() ??
                                                throw new Exception("No se pudo obtener  Usuario con ese nombre de usuario");
                return usuario;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener el usuario", ex);
            }
        }

        public Usuario ObtenerUsuario(string nombreUsuario, string passwork)
        {
            try
            {
                Usuario usuario = context.Usuario.Where(u => u.NombreUsuario == nombreUsuario && u.Contraseña == passwork).FirstOrDefault() ??
                                  throw new Exception("No se pudo obtener ningun Usuario con ese Id");

                return usuario;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener el usuario", ex);
            }
        }

        public List<Usuario> ListarUsuarios()
        {
            try
            {
                List<Usuario> usuarios = context.Usuario.ToList();

                return usuarios;                
            }
            catch (Exception ex)
            {
                throw new Exception("Ocurrio un error al obtener todos los usuarios", ex);
            }
        }

        public bool CrearUsuario(UsuarioData nuevoUsuario)
        {
            try
            {
                Usuario result = this.mapper.Map<Usuario>(nuevoUsuario);
                context.Usuario.Add(result);
                context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("Ocurrio un error al crear el Usuario", ex);
            }
        }

        public bool ModificarUsuario(UsuarioData nuevoUsuario)
        {
            try
            {
                Usuario usuarioBuscado = ObtenerUsuarioPorId(nuevoUsuario.UsuarioId);
                if (usuarioBuscado is not null)
                {                 
                        usuarioBuscado.Nombre = nuevoUsuario.Nombre;
                        usuarioBuscado.Apellido = nuevoUsuario.Apellido;
                        usuarioBuscado.NombreUsuario = nuevoUsuario.UserName;
                        usuarioBuscado.Contraseña = nuevoUsuario.Passwork;
                        usuarioBuscado.Mail = nuevoUsuario.Email;

                        context.Usuario.Update(usuarioBuscado);
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

        public bool EliminarUsuario(int id)
        {
            try
            {
                using (DataBaseContext context = new DataBaseContext())
                {
                    Usuario usuarioAeliminar = context.Usuario
                                                      .Include(p => p.Productos)
                                                      .Where(u => u.Id == id).FirstOrDefault();

                    if (usuarioAeliminar is not null)
                    {
                        context.Usuario.Remove(usuarioAeliminar);
                        context.SaveChanges();
                        return true;
                    }
                    return false;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Ocurrio un error al eliminar el Usuario", ex);
            }
        }
    }
}
