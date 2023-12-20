namespace Desafio_Clase2_Universidad
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txt_datosCargados = new Label();
            button1 = new Button();
            txt_alumno = new TextBox();
            txt_comision = new TextBox();
            txt_calificacion = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(310, 31);
            label1.Name = "label1";
            label1.Size = new Size(198, 25);
            label1.TabIndex = 0;
            label1.Text = "Ingrese Datos Alumno";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(151, 99);
            label2.Name = "label2";
            label2.Size = new Size(107, 15);
            label2.TabIndex = 1;
            label2.Text = "Nombre y Apellido";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(151, 139);
            label3.Name = "label3";
            label3.Size = new Size(58, 15);
            label3.TabIndex = 2;
            label3.Text = "Comision";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(155, 179);
            label4.Name = "label4";
            label4.Size = new Size(69, 15);
            label4.TabIndex = 3;
            label4.Text = "Calificacion";
            // 
            // txt_datosCargados
            // 
            txt_datosCargados.AutoSize = true;
            txt_datosCargados.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txt_datosCargados.Location = new Point(260, 265);
            txt_datosCargados.Name = "txt_datosCargados";
            txt_datosCargados.Size = new Size(145, 18);
            txt_datosCargados.TabIndex = 4;
            txt_datosCargados.Text = "Datos cargados";
            txt_datosCargados.Visible = false;
            // 
            // button1
            // 
            button1.Location = new Point(405, 206);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 5;
            button1.Text = "Ingresar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // txt_alumno
            // 
            txt_alumno.Location = new Point(297, 93);
            txt_alumno.Name = "txt_alumno";
            txt_alumno.Size = new Size(100, 23);
            txt_alumno.TabIndex = 6;
            // 
            // txt_comision
            // 
            txt_comision.Location = new Point(297, 136);
            txt_comision.Name = "txt_comision";
            txt_comision.Size = new Size(100, 23);
            txt_comision.TabIndex = 7;
            // 
            // txt_calificacion
            // 
            txt_calificacion.Location = new Point(297, 176);
            txt_calificacion.Name = "txt_calificacion";
            txt_calificacion.Size = new Size(100, 23);
            txt_calificacion.TabIndex = 8;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txt_calificacion);
            Controls.Add(txt_comision);
            Controls.Add(txt_alumno);
            Controls.Add(button1);
            Controls.Add(txt_datosCargados);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label txt_datosCargados;
        private Button button1;
        private TextBox txt_alumno;
        private TextBox txt_comision;
        private TextBox txt_calificacion;
    }
}
