using System;

public class Venta
{
    private long _id;
    private string _comentarios;
    private long _idUsuario;

    public Venta(string comentarios, long idUsuario)
	{
        this._comentarios = comentarios;
        this._idUsuario = idUsuario;
	}

    public long Id { get { return _id; } }

    public string Comentarios { get { return this._comentarios; } set { this._comentarios = value; } }

    public long IdUsuario { get { return this._idUsuario; } set { this._idUsuario = value; } }
}
