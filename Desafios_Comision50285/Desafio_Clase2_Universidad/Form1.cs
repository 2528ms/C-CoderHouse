namespace Desafio_Clase2_Universidad
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string alumno = txt_alumno.Text;
            char comision;
            comision = ' ';
            if (txt_comision.Text.Length > 0)
            {
               comision  = Convert.ToChar(txt_comision.Text.ToUpper());
            }
            
            
            short calificacion = Convert.ToInt16(txt_calificacion.Text);
            string turno;
            string calificacionFinal;

            switch (comision)
            {
                case 'A':
                    turno = "Turno mañana";
                    break;
                case 'B':
                    turno = "Turno tarde";
                    break;
                case 'C':
                    turno = "Turno noche";
                    break;
                default:
                    turno = "no tienen turno fijado";
                    break;
            }

            if (calificacion > 7)
            {
                calificacionFinal = "Materia promocionada";
            }
            else
            {
                if (calificacion >= 4 && calificacion <= 7)
                {
                    calificacionFinal = "Cursada Aprovada";
                }
                else
                {
                    calificacionFinal = "Recursa la Materia";
                }
            }

            txt_datosCargados.Text = $"{alumno} {turno} {calificacionFinal}";
            txt_datosCargados.Visible = true;

        }
    }
}
