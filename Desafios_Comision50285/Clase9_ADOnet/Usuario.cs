using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase9_ADOnet
{
    public class Usuario
    {
        private long _id;
        private string _nombre;
        private string _apellido;
        private string _nombreUsuaio;
        private string _contraseña;
        private string _mail;
        /*
        public Usuario(string nombre, string apellido, string nombreUsuario, string contraseña, string mail)
        {
            this._nombre = nombre;
            this._apellido = apellido;
            this._nombreUsuaio = nombreUsuario;
            this._contraseña = contraseña;
            this._mail = mail;
        }*/

        public long Id { get { return _id; } set { this._id = value; } }

        public string Nombre { get { return this._nombre; } set { this._nombre = value; } }

        public string Apellido { get { return this._apellido; } set { this._apellido = value; } }

        public string NombreUsuario { get { return this._nombreUsuaio; } set { this._nombreUsuaio = value; } }

        public string Contraseña { get { return this._contraseña; } set { this._contraseña = value; } }

        public string Mail { get { return this._mail; } set { this._mail = value; } }

    }
}
