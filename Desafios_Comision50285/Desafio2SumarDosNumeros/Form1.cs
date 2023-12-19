namespace Desafio2SumarDosNumeros
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_sumar_Click(object sender, EventArgs e)
        {
           int num1 = Convert.ToInt32(txt_num1.Text);
           int num2 = Convert.ToInt32(txt_num2.Text);

           int suma = num1 + num2;

            resultado.Text = "El resultado es: " + suma;
            resultado.Visible = true;
        }
    }
}
