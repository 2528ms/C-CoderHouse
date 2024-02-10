﻿namespace SistemaGestion.Models
{
    public partial class ProductoVendido
    {
        private int _id;
        private int _idProducto;
        private int _stock;
        private int _idVenta;

        public ProductoVendido()
        {

        }

        public ProductoVendido(int idProducto, int stock, int idVenta)
        {
            this._idProducto = idProducto;
            this._stock = stock;
            this._idVenta = idVenta;
        }

        public int Id { get { return this._id; } set { this._id = value; } }

        public int IdProducto { get { return this._idProducto; } set { this._idProducto = value; } }

        public int Stock { get { return this._stock; } set { this._stock = value; } }

        public int IdVenta { get { return this._idVenta; } set { this._idVenta = value; } }

        public virtual Producto IdProductoNavigation { get; set; } = null!;
        public virtual Venta IdVentaNavigation { get; set; } = null!;
    }
}
