using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase8_ListasAvanzadas
{
    public class ListaMayores
    {
        private List<Cliente> _clientesMayores;

        public ListaMayores()
        {
            this._clientesMayores = new List<Cliente>();
        }

        public List<Cliente> GetListaCliente()
        {
            return this._clientesMayores;
        }

        public void InsertarEnLista(Cliente[] clientes)
        {
            for (int i = 0; i < clientes.Length; i++)
            {
                this._clientesMayores.Add(new Cliente(clientes[i].ID,
                                                      clientes[i].Nombre,
                                                      clientes[i].Direccion,
                                                      clientes[i].Edad));
            }
        }

        public bool Borrar(Cliente cliente)
        {
            if (!this._clientesMayores.Contains(cliente)) return false;

            return this._clientesMayores.Remove(cliente);
        }

        public int Buscar(Cliente cliente) 
        {
            return this._clientesMayores.IndexOf(cliente);
        }

        public bool Modificar(Cliente actual, Cliente nuevo)
        {
            int position = Buscar(actual);
            if (position == -1) return false;

            this._clientesMayores[position] = nuevo;
            return true;
        }

        public void LimpiarLista()
        {
            this._clientesMayores.Clear();
        }

        public int CompararClientes(Cliente cliente1, Cliente cliente2)
        {
            return cliente1.ID.CompareTo(cliente2.ID);
        }

        public void Ordenar()
        {
            this._clientesMayores.Sort(CompararClientes);
        }
    }
}
