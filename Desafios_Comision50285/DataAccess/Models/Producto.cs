
namespace DataAccess.Models
{
    public class Producto
    {
        private int _id;
        private string _descripciones;
        private double _costo;
        private double _precioVenta;
        private int _stock;
        private int _idUsuario;

        public Producto()
        {
            ProductoVendidos = new HashSet<ProductoVendido>();
        }

        public Producto(string descripcion, double costo, double precioVenta, int stock, int UsuarioId)
        {
            this._descripciones = descripcion;
            this._costo = costo;
            this._precioVenta = precioVenta;
            this._stock = stock;
            this._idUsuario = UsuarioId;
        }


        public int Id { get { return this._id; } set { this._id = value; } }

        public string Descripciones { get { return this._descripciones; } set { this._descripciones = value; } }

        public double Costo { get { return this._costo; } set { this._costo = value; } }

        public double PrecioVenta { get { return this._precioVenta; } set { this._precioVenta = value; } }

        public int Stock { get { return this._stock; } set { this._stock = value; } }

        public int IdUsuario { get { return this._idUsuario; } set { this._idUsuario = value; } }


        public virtual Usuario IdUsuarioNavigation { get; set; } = null!;

        public virtual ICollection<ProductoVendido> ProductoVendidos { get; set; }
        
    }
}

