using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase8_ListasAvanzadas
{
    public class Cliente
    {
        public Cliente(long id,string nombre, string direccion, short edad) 
        { 
            this.ID = id;
            this.Nombre = nombre;
            this.Direccion = direccion;
            this.Edad = edad;
        }
        public string Nombre {  get; set; }

        public long ID { get; set; }

        public string Direccion { get; set;}

        public short Edad { get; set;}


        public override bool Equals(object obj)
        {
            Cliente cliente = (Cliente)obj;
            return this.ID.Equals(cliente.ID);
        }
    }
}
