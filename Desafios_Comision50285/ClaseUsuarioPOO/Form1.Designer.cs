namespace ClaseUsuarioPOO
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
            label5 = new Label();
            label6 = new Label();
            txt_nombre = new TextBox();
            txt_apellido = new TextBox();
            txt_domicilio = new TextBox();
            txt_edad = new TextBox();
            txt_dni = new TextBox();
            txt_mail = new TextBox();
            btn_mayorEdad = new Button();
            btn_cambiarDom = new Button();
            btn_esGamil = new Button();
            btn_cargar = new Button();
            lbl_resultMatorEdad = new Label();
            lbl_nuevoDomicilio = new Label();
            txt_nuevoDomicilio = new TextBox();
            lbl_resultUser = new Label();
            btn_actualizar = new Button();
            lbl_result_mail = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(162, 44);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 0;
            label1.Text = "Nombre";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(165, 84);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 1;
            label2.Text = "Apellido";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(162, 122);
            label3.Name = "label3";
            label3.Size = new Size(58, 15);
            label3.TabIndex = 2;
            label3.Text = "Domicilio";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(162, 153);
            label4.Name = "label4";
            label4.Size = new Size(33, 15);
            label4.TabIndex = 3;
            label4.Text = "Edad";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(162, 184);
            label5.Name = "label5";
            label5.Size = new Size(27, 15);
            label5.TabIndex = 4;
            label5.Text = "DNI";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(165, 215);
            label6.Name = "label6";
            label6.Size = new Size(30, 15);
            label6.TabIndex = 5;
            label6.Text = "Mail";
            // 
            // txt_nombre
            // 
            txt_nombre.Location = new Point(264, 41);
            txt_nombre.Name = "txt_nombre";
            txt_nombre.Size = new Size(100, 23);
            txt_nombre.TabIndex = 6;
            // 
            // txt_apellido
            // 
            txt_apellido.Location = new Point(264, 76);
            txt_apellido.Name = "txt_apellido";
            txt_apellido.Size = new Size(100, 23);
            txt_apellido.TabIndex = 7;
            // 
            // txt_domicilio
            // 
            txt_domicilio.Location = new Point(264, 114);
            txt_domicilio.Name = "txt_domicilio";
            txt_domicilio.Size = new Size(100, 23);
            txt_domicilio.TabIndex = 8;
            // 
            // txt_edad
            // 
            txt_edad.Location = new Point(264, 153);
            txt_edad.Name = "txt_edad";
            txt_edad.Size = new Size(100, 23);
            txt_edad.TabIndex = 9;
            // 
            // txt_dni
            // 
            txt_dni.Location = new Point(264, 184);
            txt_dni.Name = "txt_dni";
            txt_dni.Size = new Size(100, 23);
            txt_dni.TabIndex = 10;
            // 
            // txt_mail
            // 
            txt_mail.Location = new Point(264, 215);
            txt_mail.Name = "txt_mail";
            txt_mail.Size = new Size(100, 23);
            txt_mail.TabIndex = 11;
            // 
            // btn_mayorEdad
            // 
            btn_mayorEdad.Location = new Point(74, 366);
            btn_mayorEdad.Name = "btn_mayorEdad";
            btn_mayorEdad.Size = new Size(95, 23);
            btn_mayorEdad.TabIndex = 12;
            btn_mayorEdad.Text = "Mayor Edad";
            btn_mayorEdad.UseVisualStyleBackColor = true;
            btn_mayorEdad.Click += btn_mayorEdad_Click;
            // 
            // btn_cambiarDom
            // 
            btn_cambiarDom.Location = new Point(296, 366);
            btn_cambiarDom.Name = "btn_cambiarDom";
            btn_cambiarDom.Size = new Size(141, 23);
            btn_cambiarDom.TabIndex = 13;
            btn_cambiarDom.Text = "Cambiar Domicilio";
            btn_cambiarDom.UseVisualStyleBackColor = true;
            btn_cambiarDom.Click += btn_cambiarDom_Click;
            // 
            // btn_esGamil
            // 
            btn_esGamil.Location = new Point(574, 366);
            btn_esGamil.Name = "btn_esGamil";
            btn_esGamil.Size = new Size(141, 23);
            btn_esGamil.TabIndex = 14;
            btn_esGamil.Text = "es Gmail";
            btn_esGamil.UseVisualStyleBackColor = true;
            btn_esGamil.Click += btn_esGamil_Click;
            // 
            // btn_cargar
            // 
            btn_cargar.Location = new Point(425, 152);
            btn_cargar.Name = "btn_cargar";
            btn_cargar.Size = new Size(95, 23);
            btn_cargar.TabIndex = 15;
            btn_cargar.Text = "Cargar User";
            btn_cargar.UseVisualStyleBackColor = true;
            btn_cargar.Click += btn_cargar_Click;
            // 
            // lbl_resultMatorEdad
            // 
            lbl_resultMatorEdad.AutoSize = true;
            lbl_resultMatorEdad.Location = new Point(47, 454);
            lbl_resultMatorEdad.Name = "lbl_resultMatorEdad";
            lbl_resultMatorEdad.Size = new Size(98, 15);
            lbl_resultMatorEdad.TabIndex = 16;
            lbl_resultMatorEdad.Text = "resul mayot edad";
            lbl_resultMatorEdad.Visible = false;
            // 
            // lbl_nuevoDomicilio
            // 
            lbl_nuevoDomicilio.AutoSize = true;
            lbl_nuevoDomicilio.Location = new Point(254, 454);
            lbl_nuevoDomicilio.Name = "lbl_nuevoDomicilio";
            lbl_nuevoDomicilio.Size = new Size(96, 15);
            lbl_nuevoDomicilio.TabIndex = 17;
            lbl_nuevoDomicilio.Text = "Nuevo Domicilio";
            lbl_nuevoDomicilio.Visible = false;
            // 
            // txt_nuevoDomicilio
            // 
            txt_nuevoDomicilio.Location = new Point(375, 446);
            txt_nuevoDomicilio.Name = "txt_nuevoDomicilio";
            txt_nuevoDomicilio.Size = new Size(100, 23);
            txt_nuevoDomicilio.TabIndex = 18;
            txt_nuevoDomicilio.Visible = false;
            // 
            // lbl_resultUser
            // 
            lbl_resultUser.AutoSize = true;
            lbl_resultUser.Location = new Point(254, 297);
            lbl_resultUser.Name = "lbl_resultUser";
            lbl_resultUser.Size = new Size(82, 15);
            lbl_resultUser.TabIndex = 19;
            lbl_resultUser.Text = "resultado User";
            lbl_resultUser.Visible = false;
            // 
            // btn_actualizar
            // 
            btn_actualizar.Location = new Point(316, 495);
            btn_actualizar.Name = "btn_actualizar";
            btn_actualizar.Size = new Size(95, 23);
            btn_actualizar.TabIndex = 20;
            btn_actualizar.Text = "Actualizar";
            btn_actualizar.UseVisualStyleBackColor = true;
            btn_actualizar.Visible = false;
            btn_actualizar.Click += btn_actualizar_Click;
            // 
            // lbl_result_mail
            // 
            lbl_result_mail.AutoSize = true;
            lbl_result_mail.Location = new Point(587, 475);
            lbl_result_mail.Name = "lbl_result_mail";
            lbl_result_mail.Size = new Size(98, 15);
            lbl_result_mail.TabIndex = 21;
            lbl_result_mail.Text = "resul mayot edad";
            lbl_result_mail.Visible = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 569);
            Controls.Add(lbl_result_mail);
            Controls.Add(btn_actualizar);
            Controls.Add(lbl_resultUser);
            Controls.Add(txt_nuevoDomicilio);
            Controls.Add(lbl_nuevoDomicilio);
            Controls.Add(lbl_resultMatorEdad);
            Controls.Add(btn_cargar);
            Controls.Add(btn_esGamil);
            Controls.Add(btn_cambiarDom);
            Controls.Add(btn_mayorEdad);
            Controls.Add(txt_mail);
            Controls.Add(txt_dni);
            Controls.Add(txt_edad);
            Controls.Add(txt_domicilio);
            Controls.Add(txt_apellido);
            Controls.Add(txt_nombre);
            Controls.Add(label6);
            Controls.Add(label5);
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
        private Label label5;
        private Label label6;
        private TextBox txt_nombre;
        private TextBox txt_apellido;
        private TextBox txt_domicilio;
        private TextBox txt_edad;
        private TextBox txt_dni;
        private TextBox txt_mail;
        private Button btn_mayorEdad;
        private Button btn_cambiarDom;
        private Button btn_esGamil;
        private Button btn_cargar;
        private Label lbl_resultMatorEdad;
        private Label lbl_nuevoDomicilio;
        private TextBox txt_nuevoDomicilio;
        private Label lbl_resultUser;
        private Button btn_actualizar;
        private Label lbl_result_mail;
    }
}
