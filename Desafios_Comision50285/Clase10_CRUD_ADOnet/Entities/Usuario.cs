using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase10_CRUD_ADOnet.Entities
{
    using System;

    public class Usuario
    {
        private long _id;
        private string _nombre;
        private string _apellido;
        private string _nombreUsuario;
        private string _password;
        private string _mail;

        public Usuario() { }

        public Usuario(string nombre, string apellido, string nombreUsuario, string contraseña, string mail)
        {
            this._nombre = nombre;
            this._apellido = apellido;
            this._nombreUsuario = nombreUsuario;
            this._password = contraseña;
            this._mail = mail;
        }

        public Usuario(long id, string nombre, string apellido, string nombreUsuario, string contraseña, string mail) : this(nombre,apellido,nombreUsuario,contraseña,mail)
        {
            this._id = id;
        }

        public long Id { get => _id; set => _id = value; }
        public string Nombre { get => _nombre; set => _nombre = value; }
        public string Apellido { get => _apellido; set => _apellido = value; }
        public string NombreUsuario { get => _nombreUsuario; set => _nombreUsuario = value; }
        public string Password { get => this._password; set => this._password = value; }
        public string Mail { get => _mail; set => _mail = value; }

        public override string ToString()
        {
            return $"nombre: {this.Nombre}, apellido: {this.Apellido}";
        }
    }
}
