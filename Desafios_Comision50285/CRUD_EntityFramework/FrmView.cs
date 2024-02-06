using DataAccess.DataBase;
using DataAccess.Models;
using DataAccess.Services;

namespace CRUD_EntityFramework
{
    public partial class FrmView : Form
    {
        public FrmView()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            /* Obtener Usuario */
            //var user = UsuarioData.ObtenerUsuarioPorId(4);
            //List<Usuario> dato = new List<Usuario>() { user };
            //this.ActualizarDatos(dato);

            /* Listar Usuarios */
            //var dato = UsuarioData.ListarUsuarios();
            //this.ActualizarDatos(dato);

            /* Crear Usuario */
            //Usuario newUser = new Usuario("Mariano", "Sosa", "msosa", "ms1234", "msosa@gmail.com");
            //if (UsuarioData.CrearUsuario(newUser))
            //{
            //    MessageBox.Show("Usuario Creado Exitosamente");
            //}

            /* Actualizar Usuario */
            //Usuario newUser = new Usuario("Mariano", "Sosa", "msosa28", "123456", "msosa@gmail.com");
            //if (UsuarioData.ModificarUsuarioPorId(newUser, 6))
            //{
            //    MessageBox.Show("Usuario fue actualizado Exitosamente");
            //}

            /* Eliminar Usuarios */
            if (UsuarioData.EliminarUsuario(6))
            {
                MessageBox.Show("Usuario Eliminado Exitosamente");
            }

        }

        private void ActualizarDatos(object obj)
        {
            this.dgvDatos.DataSource = null;
            this.dgvDatos.DataSource = obj;
        }

        private void btnProducto_Click(object sender, EventArgs e)
        {
            /*Listar Productos*/
            //var dato = ProductoData.ListarProductos();
            //this.ActualizarDatos(dato);


            /* Obtener Producto */
            //var prod = ProductoData.ObtenerProductoPorId(4);
            //List<Producto> dato = new List<Producto>() { prod };
            //this.ActualizarDatos(dato);

            /* Crear Producto */
            //Producto nuevoProducto = new Producto("descripcion", 10.00, 20.00, 20, 4);

            //if (ProductoData.CrearProducto(nuevoProducto))
            //{
            //    MessageBox.Show("Producto creado Exitosamente");
            //}

            /* Actualizar Producto */
            //Producto nuevoProducto = new Producto("producto test", 600.0, 1800.00, 20, 1);

            //if (ProductoData.ModificarProductoPorId(nuevoProducto, 22))
            //{
            //    MessageBox.Show("Producto Actualizado Exitosamente");
            //}

            /* Eliminar Usuarios */
            if (ProductoData.EliminarProductoPorId(22))
            {
                MessageBox.Show("Producto Eliminado Exitosamente");
            }

        }

        private void btnVenta_Click(object sender, EventArgs e)
        {
            /* Obtener Venta */
            //var venta = VentaData.ObtenerProductoPorId(3);
            //List<Venta> dato = new List<Venta>() { venta };
            //this.ActualizarDatos(dato);

            /* Listar Venta */
            //var dato = VentaData.ListarVentas();
            //this.ActualizarDatos(dato);

            /*Crear Venta*/
            //Venta nuevaVenta = new Venta("Comentario creacion", 1);
            //if (VentaData.CrearVenta(nuevaVenta))
            //{
            //    MessageBox.Show("Venta creada Exitosamente");
            //}

            /*Actualizar Venta*/
            //Venta nuevaVenta = new Venta("Comentario actualizacion", 2);
            //if (VentaData.ModificarVentaPorId(nuevaVenta,11))
            //{
            //    MessageBox.Show("Venta actualizada Exitosamente");
            //}

            /*Eliminar Venta*/
            if (VentaData.EliminarVentaPorId(12))
            {
                MessageBox.Show("Venta eliminada Exitosamente");
            }
        }



        private void btnProductoVendido_Click(object sender, EventArgs e)
        {
            /* Obtener ProductoVendido */
            //var prod = ProductoVendidoData.ObtenerProductoVendidoporId(3);
            //List<ProductoVendido> dato = new List<ProductoVendido>() { prod };
            //this.ActualizarDatos(dato);


            /* Listar ProductoVendido */
            //var dato = ProductoVendidoData.ListarProductoVendidos();            
            //this.ActualizarDatos(dato);

            /*Crear ProductoVendido*/
            //ProductoVendido productoVendido = new ProductoVendido(2,5,2);
            //if (ProductoVendidoData.CrearProductoVendido(productoVendido))
            //{
            //    MessageBox.Show("ProductoVendido creado Exitosamente");
            //}

            /*Actualizar ProductoVendido*/
            //ProductoVendido productoVendido = new ProductoVendido(1, 1, 1);
            //if (ProductoVendidoData.ModificarProductoVendidoPorId(productoVendido,12))
            //{
            //    MessageBox.Show("ProductoVendido actualizado Exitosamente");
            //}

            /*Eliminar ProductoVendido*/
            
            if (ProductoVendidoData.EliminarProductoVendidoPorId(12))
            {
                MessageBox.Show("ProductoVendido eliminado Exitosamente");
            }
        }
    }
}
