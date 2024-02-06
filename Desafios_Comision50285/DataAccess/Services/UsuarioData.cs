using DataAccess.DataBase;
using DataAccess.Models;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Services
{
    public static class UsuarioData
    {
        public static Usuario ObtenerUsuarioPorId(int id)
        {
            try
            {
                using (DataBaseContext context = new DataBaseContext())
                {
                    Usuario usuario = context.Usuario.Where(u => u.Id == id).FirstOrDefault();

                    if (usuario == null)
                    {
                        throw new Exception("No se pudo obtener ningun Usuario con ese Id");
                    }
                    return usuario;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener el usuario", ex);
            }
        }

        public static List<Usuario> ListarUsuarios()
        {           
            try
            {
                using (DataBaseContext context = new DataBaseContext())
                {
                    List<Usuario> usuarios = context.Usuario.ToList();

                    return usuarios;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Ocurrio un error al obtener todos los usuarios", ex);
            }
        }
       
        public static bool CrearUsuario(Usuario nuevoUsuario)
        {
            try
            {
                using (DataBaseContext context = new DataBaseContext())
                {
                    context.Usuario.Add(nuevoUsuario);
                    context.SaveChanges();
                    return true;
                }
            }
            catch (Exception ex)
            {                                
                throw new Exception("Ocurrio un error al crear el Usuario", ex);
            }
        }
      
        public static bool ModificarUsuarioPorId(Usuario usuario, int id)
        {
            try
            {
                Usuario usuarioBuscado = ObtenerUsuarioPorId(id);
                if (usuarioBuscado is not null)
                {
                    using (DataBaseContext context = new DataBaseContext())
                    {
                        usuarioBuscado.Nombre = usuario.Nombre;
                        usuarioBuscado.Apellido = usuario.Apellido;
                        usuarioBuscado.NombreUsuario = usuario.NombreUsuario;
                        usuarioBuscado.Contraseña = usuario.Contraseña;
                        usuarioBuscado.Mail = usuario.Mail;

                        context.Usuario.Update(usuarioBuscado);
                        context.SaveChanges();
                        return true;
                    }
                }
                return false;
            }
            catch (Exception ex)
            {
                throw new Exception("Ocurrio un error al modificar el Usuario", ex);
            }
        }

        public static bool EliminarUsuario(int id)
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
