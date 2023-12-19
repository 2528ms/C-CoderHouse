namespace Desafio1NombreApellido
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void submit_Click(object sender, EventArgs e)
        {
            string nombre = txt_name.Text;
            string apellido = txt_apellido.Text;
            user.Text = nombre + " " + apellido;
            user.Visible = true;

            string dni = txt_dni.Text;
            string edad = txt_edad.Text;
            string altura = txt_altura.Text;

            dni_ingresado.Text = "DNI " + dni;
            edad_ingresada.Text = "Edad " + edad;
            altura_ingresada.Text = "Altura " + altura;

            dni_ingresado.Visible = true;
            edad_ingresada.Visible = true;
            altura_ingresada.Visible = true;
        }

       
    }
}
