namespace DataAccess.Models
{
    public class Venta
    {
        private int _id;
        private string _comentarios;
        private int _idUsuario;

        public Venta()
        {
            ProductoVendidos = new HashSet<ProductoVendido>();
        }

        public Venta(string comentarios, int idUsuario)
        {
            this.Comentarios = comentarios;
            this.IdUsuario = idUsuario;
        }

        public int Id { get; set; }
        public string? Comentarios { get; set; }
        public int IdUsuario { get; set; }

        public virtual Usuario IdUsuarioNavigation { get; set; } = null!;
        public virtual ICollection<ProductoVendido> ProductoVendidos { get; set; }
    }
}
