using Clase10_CRUD_ADOnet.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase10_CRUD_ADOnet.DataBase
{
    public class GestorDataBase
    {
        private string _stringConnection;

        public GestorDataBase()
        {
            this._stringConnection = @"Server=localhost\SQLEXPRESS;Database=CoderHouse;Trusted_Connection=True;";
        }

        public Usuario GetUsuarioById(int id)
        {
            using (SqlConnection connection = new SqlConnection(this._stringConnection))
            {
                string query = "Select * From Usuario Where Id= @id";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("id", id);

                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read()) 
                { 
                    int idEncontrado = Convert.ToInt32(reader["Id"]);
                    string nombre = reader.GetString(1);
                    string apellido = reader.GetString(2);
                    string nombreUsuario = reader.GetString(3);
                    string password = reader.GetString(4);
                    string email = reader.GetString(5);


                    Usuario usuario = new Usuario(idEncontrado, nombre, apellido, nombreUsuario, password, email);
                    return usuario;
                }

                throw new Exception("Id no encontrado");
            }
        }

        public bool AddUser(Usuario usuario)
        {
            using (SqlConnection connection = new SqlConnection(this._stringConnection))
            {
                string query = "INSERT INTO Usuario (Nombre,Apellido,NombreUsuario,Contraseña,Mail) values (@nombre,@apellido,@nombreUsuario,@password,@email);";
                //string query = "INSERT INTO Usuario (Nombre,Apellido,NombreUsuario,Contraseña,Mail) values (@nombre,@apellido,@nombreUsuario,@password,@email); select @@IDENTITY as ID";

                SqlCommand command = new SqlCommand(query, connection);

                command.Parameters.AddWithValue("nombre", usuario.Nombre);
                command.Parameters.AddWithValue("apellido", usuario.Apellido);
                command.Parameters.AddWithValue("nombreUsuario", usuario.NombreUsuario);
                command.Parameters.AddWithValue("password", usuario.Password);
                command.Parameters.AddWithValue("email", usuario.Mail);
                connection.Open();

                return command.ExecuteNonQuery() > 0;
            }
        }

        public bool DeleteUserById(int id)
        {
            using (SqlConnection connection = new SqlConnection(this._stringConnection))
            {
                string query = "DELETE FROM Usuario WHERE id = @id";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("id", id);

                connection.Open();
                return command.ExecuteNonQuery() > 0;

            }
        }

        public bool UpdateUserById(int id, Usuario usuario)
        {
            using (SqlConnection connection = new SqlConnection(this._stringConnection))
            {
                string query = "UPDATE Usuario SET Nombre = @nombre,Apellido = @apellido,NombreUsuario = @nombreUsuario,Contraseña= @password,Mail=@email WHERE id = @id ";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("id", id);
                command.Parameters.AddWithValue("nombre", usuario.Nombre);
                command.Parameters.AddWithValue("apellido", usuario.Apellido);
                command.Parameters.AddWithValue("nombreUsuario", usuario.NombreUsuario);
                command.Parameters.AddWithValue("password", usuario.Password);
                command.Parameters.AddWithValue("email", usuario.Mail);
                connection.Open();
                return command.ExecuteNonQuery() > 0;
            }

        }
    }
}
