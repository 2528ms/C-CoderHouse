namespace ClaseUsuarioPOO
{
    public partial class Form1 : Form
    {
        private Usuario user;
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_cargar_Click(object sender, EventArgs e)
        {
            var nombre = txt_nombre.Text;
            var apellido = txt_apellido.Text;
            var domicilio = txt_domicilio.Text;
            var mail = txt_mail.Text;
            var edad = Convert.ToInt16(txt_edad.Text);
            var dni = Convert.ToInt32(txt_dni.Text);


            this.user = new Usuario(nombre, apellido, domicilio, mail, edad, dni);


            lbl_resultUser.Text = mostrarResultadoUser();
            lbl_resultUser.Visible = true;
        }

        private void btn_mayorEdad_Click(object sender, EventArgs e)
        {
            var result = "El usuario NO es mayor de edad";

            if (this.user.isMayorEdad())
            {
                result = "El usuario es mayor de edad";
            }

            lbl_resultMatorEdad.Text = result;
            lbl_resultMatorEdad.Visible = true;
        }

        private void btn_cambiarDom_Click(object sender, EventArgs e)
        {
            lbl_nuevoDomicilio.Visible = true;
            txt_nuevoDomicilio.Visible = true;
            btn_actualizar.Visible = true;


        }

        private string mostrarResultadoUser()
        {
            //return this.user.Nombre + " " + this.user.Apellido + " " + this.user.Domicilio;
            var test = this.user.Nombre;
            return test;

        }

        private void btn_actualizar_Click(object sender, EventArgs e)
        {
            this.user.cambiarDomicilio(txt_nuevoDomicilio.Text);
        }

        private void btn_esGamil_Click(object sender, EventArgs e)
        {
           
            var result = "El mail NO es gmail";

            if (this.user.isGmail())
            {
                result = "El mail es gmail";
            }

            lbl_result_mail.Text = result;
            lbl_result_mail.Visible = true;
          
        }
    }
}
