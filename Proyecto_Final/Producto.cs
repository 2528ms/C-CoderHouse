using System;

public class Producto
{
    private long _id;
    private string _descripcion;
    private double _costo;
    private double _precioVenta;
    private int _stock;
    private long _idUsuario;


    public Producto(string descripcion, double costo, double precioVenta, int stock, long idUsuario)
    {
        this._descripcion = descripcion;
        this._costo = costo;
        this._precioVenta = precioVenta;
        this._stock = stock;
        this._idUsuario = idUsuario;
    }

    public long Id { get { return _id; } }

    public string Descripcion { get { return this._descripcion; } set { this._descripcion = value; } }

    public double Costo { get { return this._costo; } set { this._costo = value; } }

    public double PrecioVenta { get { return this._precioVenta; } set { this._precioVenta = value; } }

    public int Stock { get { return this._stock; } }

    public long IdUsuario { get { return this._idUsuario; } set { this._idUsuario = value; } }
}
