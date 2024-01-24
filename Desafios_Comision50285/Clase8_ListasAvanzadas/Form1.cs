namespace Clase8_ListasAvanzadas
{
    public partial class Form1 : Form
    {
        ListaMayores listaMayores;
        public Form1()
        {
            InitializeComponent();
        }
        private void CargaMayores()
        {
            dgvNombres.DataSource = null;
            dgvNombres.AutoGenerateColumns = true;
            dgvNombres.DataSource = listaMayores.GetListaCliente();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listaMayores = new ListaMayores();

            Cliente[] clientes = {  new Cliente(12354, "Juan Perez", "Larrea 432", 52),
                                    new Cliente(25426, "Elsa Aguirre", "La Rioja 852", 35),
                                    new Cliente(87525, "Laura Gonzalez", "Av La Plata 1565", 45),
                                    new Cliente(75652, "Rene Mendez", "San Bautista 758", 25),
                                    new Cliente(65854, "Elena Perez", "Larrea 432", 49),
                                 };

            listaMayores.InsertarEnLista(clientes);

            CargaMayores();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Cliente clienteActual = new Cliente(12354, "Juan Perez", "Larrea 432", 52);
            Cliente clienteNuevo = new Cliente(33333, "Mariano Sosa", "Pedro Goytia 1014", 27);

            listaMayores.Modificar(clienteActual, clienteNuevo);

            CargaMayores();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            Cliente clienteABorrar = new Cliente(75652, "Rene Mendez", "San Bautista 758", 25);
            listaMayores.Borrar(clienteABorrar);

            CargaMayores();
        }

        private void btnOrdenar_Click(object sender, EventArgs e)
        {
            listaMayores.Ordenar();
            CargaMayores();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            listaMayores.LimpiarLista();
            CargaMayores();
        }
    }
}
