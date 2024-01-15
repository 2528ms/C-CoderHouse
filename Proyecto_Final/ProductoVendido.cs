using System;

public class ProductoVendido
{
    private long _id;
    private long _idProducto;
    private int _stock;
    private long _idVenta;

    public ProductoVendido(long idProducto, int stock, long idVenta)
	{
        this._idProducto = idProducto;
        this._stock = stock;
        this._idVenta = idVenta;
	}

    public long Id { get { return _id; } }

    public long IdProducto { get { return this._idProducto; } set { this._idProducto = value; } }

    public int Stock { get { return this._stock; } }

    public long IdVenta { get { return this._idVenta; } set { this._idVenta = value; } }

}
