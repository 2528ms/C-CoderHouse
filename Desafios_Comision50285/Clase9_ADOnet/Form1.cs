using System.Data.SqlClient;

namespace Clase9_ADOnet
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load_1(object sender, EventArgs e)
        {
            string connectionString = @"Server=localhost\SQLEXPRESS;Database=master;Trusted_Connection=True;";

            List<Producto> listaProductos = new List<Producto>();
            List<Usuario> listaUsuarios = new List<Usuario>();

            var queryProducto = "select Id,Descripciones,Costo,PrecioVenta,Stock,IdUsuario from Producto;";
            var queryUsuarios = "select * from Usuario;";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(queryProducto, connection))
                {
                    using (SqlDataReader dataReader = command.ExecuteReader())
                    {
                        if (dataReader.HasRows)
                        {
                            while(dataReader.Read())
                            {
                                var producto = new Producto();
                                producto.Id = Convert.ToInt64(dataReader["Id"]);
                                producto.Descripcion = dataReader["Descripciones"].ToString();
                                producto.Costo = Convert.ToDouble(dataReader["Costo"]);
                                producto.PrecioVenta = Convert.ToDouble(dataReader["PrecioVenta"]);
                                producto.Stock = Convert.ToInt32(dataReader["Stock"]);
                                producto.IdUsuario =  Convert.ToInt64(dataReader["IdUsuario"]);

                                listaProductos.Add(producto);
                            }
                        }
                    }
                }

                using (SqlCommand command2 = new SqlCommand(queryUsuarios, connection))
                {
                    using (SqlDataReader dataReader2 = command2.ExecuteReader())
                    {
                        if (dataReader2.HasRows)
                        {
                            while (dataReader2.Read())
                            {
                                var usuario = new Usuario();
                                usuario.Id = Convert.ToInt64(dataReader2["Id"]);
                                usuario.Nombre = dataReader2["Nombre"].ToString();
                                usuario.Apellido = dataReader2["Apellido"].ToString();
                                usuario.NombreUsuario = dataReader2["NombreUsuario"].ToString();
                                usuario.Contraseña = dataReader2["Contraseña"].ToString();
                                usuario.Mail = dataReader2["Mail"].ToString();

                                listaUsuarios.Add(usuario);
                            }
                        }
                    }
                }
            }

            dataGridView1.DataSource = listaProductos;
            dataGridView1.AutoGenerateColumns = true;

            dataGridView2.DataSource = listaUsuarios;
            dataGridView2.AutoGenerateColumns = false;

        }
    }
}
