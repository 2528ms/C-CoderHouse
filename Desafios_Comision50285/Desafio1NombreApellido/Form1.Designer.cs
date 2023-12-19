namespace Desafio1NombreApellido
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
            lbl_name = new Label();
            lbl_apellido = new Label();
            lbl_edad = new Label();
            lbl_altura = new Label();
            lbl_dni = new Label();
            submit = new Button();
            txt_name = new TextBox();
            label2 = new Label();
            user = new Label();
            txt_apellido = new TextBox();
            txt_dni = new TextBox();
            txt_edad = new TextBox();
            txt_altura = new TextBox();
            dni_ingresado = new Label();
            edad_ingresada = new Label();
            altura_ingresada = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(242, 40);
            label1.Name = "label1";
            label1.Size = new Size(97, 15);
            label1.TabIndex = 0;
            label1.Text = "Ingrese sus datos";
            // 
            // lbl_name
            // 
            lbl_name.AutoSize = true;
            lbl_name.Location = new Point(138, 87);
            lbl_name.Name = "lbl_name";
            lbl_name.Size = new Size(51, 15);
            lbl_name.TabIndex = 1;
            lbl_name.Text = "Nombre";
            // 
            // lbl_apellido
            // 
            lbl_apellido.AutoSize = true;
            lbl_apellido.Location = new Point(138, 116);
            lbl_apellido.Name = "lbl_apellido";
            lbl_apellido.Size = new Size(51, 15);
            lbl_apellido.TabIndex = 2;
            lbl_apellido.Text = "Apellido";
            // 
            // lbl_edad
            // 
            lbl_edad.AutoSize = true;
            lbl_edad.Location = new Point(138, 174);
            lbl_edad.Name = "lbl_edad";
            lbl_edad.Size = new Size(33, 15);
            lbl_edad.TabIndex = 3;
            lbl_edad.Text = "Edad";
            // 
            // lbl_altura
            // 
            lbl_altura.AutoSize = true;
            lbl_altura.Location = new Point(138, 203);
            lbl_altura.Name = "lbl_altura";
            lbl_altura.Size = new Size(39, 15);
            lbl_altura.TabIndex = 4;
            lbl_altura.Text = "Altura";
            // 
            // lbl_dni
            // 
            lbl_dni.AutoSize = true;
            lbl_dni.Location = new Point(138, 145);
            lbl_dni.Name = "lbl_dni";
            lbl_dni.Size = new Size(27, 15);
            lbl_dni.TabIndex = 5;
            lbl_dni.Text = "DNI";
          
            // 
            // submit
            // 
            submit.Location = new Point(382, 225);
            submit.Name = "submit";
            submit.Size = new Size(75, 23);
            submit.TabIndex = 6;
            submit.Text = "Submit";
            submit.UseVisualStyleBackColor = true;
            submit.Click += submit_Click;
            // 
            // txt_name
            // 
            txt_name.Location = new Point(239, 83);
            txt_name.Name = "txt_name";
            txt_name.Size = new Size(100, 23);
            txt_name.TabIndex = 7;
            txt_name.Tag = "name_in";
            // 
            // label2
            // 
            label2.Location = new Point(0, 0);
            label2.Name = "label2";
            label2.Size = new Size(100, 23);
            label2.TabIndex = 0;
            // 
            // user
            // 
            user.AutoSize = true;
            user.Location = new Point(138, 270);
            user.Name = "user";
            user.Size = new Size(98, 15);
            user.TabIndex = 8;
            user.Tag = "datos_ingresados";
            user.Text = "Datos del usuario";
            user.Visible = false;
            // 
            // txt_apellido
            // 
            txt_apellido.Location = new Point(239, 112);
            txt_apellido.Name = "txt_apellido";
            txt_apellido.Size = new Size(100, 23);
            txt_apellido.TabIndex = 9;
            // 
            // txt_dni
            // 
            txt_dni.Location = new Point(239, 141);
            txt_dni.Name = "txt_dni";
            txt_dni.Size = new Size(100, 23);
            txt_dni.TabIndex = 10;
            // 
            // txt_edad
            // 
            txt_edad.Location = new Point(239, 170);
            txt_edad.Name = "txt_edad";
            txt_edad.Size = new Size(100, 23);
            txt_edad.TabIndex = 11;
            // 
            // txt_altura
            // 
            txt_altura.Location = new Point(239, 199);
            txt_altura.Name = "txt_altura";
            txt_altura.Size = new Size(100, 23);
            txt_altura.TabIndex = 12;
            // 
            // dni_ingresado
            // 
            dni_ingresado.AutoSize = true;
            dni_ingresado.Location = new Point(138, 301);
            dni_ingresado.Name = "dni_ingresado";
            dni_ingresado.Size = new Size(27, 15);
            dni_ingresado.TabIndex = 13;
            dni_ingresado.Tag = "datos_ingresados";
            dni_ingresado.Text = "DNI";
            dni_ingresado.Visible = false;
            // 
            // edad_ingresada
            // 
            edad_ingresada.AutoSize = true;
            edad_ingresada.Location = new Point(138, 332);
            edad_ingresada.Name = "edad_ingresada";
            edad_ingresada.Size = new Size(33, 15);
            edad_ingresada.TabIndex = 14;
            edad_ingresada.Tag = "datos_ingresados";
            edad_ingresada.Text = "Edad";
            edad_ingresada.Visible = false;
            // 
            // altura_ingresada
            // 
            altura_ingresada.AutoSize = true;
            altura_ingresada.Location = new Point(138, 363);
            altura_ingresada.Name = "altura_ingresada";
            altura_ingresada.Size = new Size(39, 15);
            altura_ingresada.TabIndex = 15;
            altura_ingresada.Text = "Altura";
            altura_ingresada.Visible = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(altura_ingresada);
            Controls.Add(edad_ingresada);
            Controls.Add(dni_ingresado);
            Controls.Add(txt_altura);
            Controls.Add(txt_edad);
            Controls.Add(txt_dni);
            Controls.Add(txt_apellido);
            Controls.Add(user);
            Controls.Add(label2);
            Controls.Add(txt_name);
            Controls.Add(submit);
            Controls.Add(lbl_dni);
            Controls.Add(lbl_altura);
            Controls.Add(lbl_edad);
            Controls.Add(lbl_apellido);
            Controls.Add(lbl_name);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lbl_name;
        private Label lbl_apellido;
        private Label lbl_edad;
        private Label lbl_altura;
        private Label lbl_dni;
        private Button submit;
        private TextBox txt_name;
        private Label label2;
        private Label user;
        private TextBox txt_apellido;
        private TextBox txt_dni;
        private TextBox txt_edad;
        private TextBox txt_altura;
        private Label dni_ingresado;
        private Label edad_ingresada;
        private Label altura_ingresada;
    }
}
