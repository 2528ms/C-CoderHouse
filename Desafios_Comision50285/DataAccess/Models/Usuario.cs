
using System;

namespace DataAccess.Models
{
    public class Usuario
    {
        private int _id;
        private string _nombre;
        private string _apellido;
        private string _nombreUsuaio;
        private string _contrasenia;
        private string _mail;


        public Usuario()
        {
            Productos = new HashSet<Producto>();
            Venta = new HashSet<Venta>();
        }

        public Usuario(string nombre, string apellido, string nombreUsuario, string contrasenia, string mail)
        {
            this._nombre = nombre;
            this._apellido = apellido;
            this._nombreUsuaio = nombreUsuario;
            this._contrasenia = contrasenia;
            this._mail = mail;
        }

        public int Id { get { return this._id; } set { this._id = value; } }

        public string Nombre { get { return this._nombre; } set { this._nombre = value; } }

        public string Apellido { get { return this._apellido; } set { this._apellido = value; } }

        public string NombreUsuario { get { return this._nombreUsuaio; } set { this._nombreUsuaio = value; } }

        public string Contraseña { get { return this._contrasenia; } set { this._contrasenia = value; } }

        public string Mail { get { return this._mail; } set { this._mail = value; } }

        public virtual ICollection<Producto> Productos { get; set; }

        public virtual ICollection<Venta> Venta { get; set; }

    }
}
