using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Clase9_ADOnet
{
    public class Producto
    {
        private long _id;
        private string _descripcion;
        private double _costo;
        private double _precioVenta;
        private int _stock;
        private long _idUsuario;



        public long Id { get => this._id; set => this._id = value; }

        public string Descripcion { get => this._descripcion;  set => this._descripcion = value; }

        public double Costo { get => this._costo;  set => this._costo = value; } 

        public double PrecioVenta { get => this._precioVenta; set => this._precioVenta = value; }

        public int Stock { get => this._stock; set => this._stock = value; } 

        public long IdUsuario { get => this._idUsuario; set => this._idUsuario = value; }
    }

}
