using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseUsuarioPOO
{
    internal class Usuario
    {
        private string _nombre;
        private string _apellido;
        private string _domicilio;
        private string _mail;
        private int _edad;
        private long _dni;

        public Usuario(string nombre, string apellido, string domicilio, string mail, int edad, long dni)
        {
            this._nombre = nombre;
            this._apellido = apellido;
            this._domicilio = domicilio;
            this._mail = mail;
            this._edad = edad;
            this._dni = dni;
        }

        public string Nombre { get; set; }

        public string Apellido { get; set; }

        public string Domicilio { get; set; }

        public string Mail { get; set; }

        public int Edad { get; set; }

        public long Dni { get; set; }

        public bool isMayorEdad()
        {
            return this._edad > 18;
        }

        public string cambiarDomicilio(string newDomicilio)
        {
            return this._domicilio = newDomicilio;
        }

        public bool isGmail()
        {
            const string gmail = "@gmail.com";
            return this._mail.Contains(gmail);
        }
    }
}
