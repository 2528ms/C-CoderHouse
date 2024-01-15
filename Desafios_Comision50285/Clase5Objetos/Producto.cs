using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Clase5Objetos
{
    internal class Producto
    {
        private int _codigo;
        private string _descripcion;
        private double _precioVenta;
        private double _precioCompra;
        private string _categoria;

        //Propiedad comun
        public int Codigo
        {
            get {   return _codigo;}
            set { _codigo = value; }
        }
        public string Descripcion
        {
            get { return _descripcion; }
            set { _descripcion = value; }
        }

        //Propiedad autoimplementada
        public double PrecioVenta { get; set; }

        public double PrecioCompra { get; set; }

        public string Categoria
        {
            get { return _categoria; }
            set { _categoria = value; }
        }

        public Producto() {
            this._codigo = 0;
            this._descripcion = string.Empty;
            this._precioVenta = 0;
            this._precioCompra = 0;
            this._categoria = string.Empty;
        }

        public Producto(int codigo, string descripcion, int precioVenta, int precioCompra, string categoria)
        {
            this._codigo = codigo;
            this._descripcion = descripcion;
            this._precioVenta = precioVenta;
            this._precioCompra = precioCompra;
            this._categoria = categoria;
        }

        public bool HayPrecioVenta()
        {
            return this._precioVenta > 0;
        }

       
    }
}
