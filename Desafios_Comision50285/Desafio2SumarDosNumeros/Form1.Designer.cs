namespace Desafio2SumarDosNumeros
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
            btn_sumar = new Button();
            label2 = new Label();
            label3 = new Label();
            txt_num1 = new TextBox();
            txt_num2 = new TextBox();
            resultado = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(253, 48);
            label1.Name = "label1";
            label1.Size = new Size(344, 28);
            label1.TabIndex = 0;
            label1.Text = "Ingrese dos numeros que desea sumar";
            // 
            // btn_sumar
            // 
            btn_sumar.Location = new Point(437, 247);
            btn_sumar.Name = "btn_sumar";
            btn_sumar.Size = new Size(75, 23);
            btn_sumar.TabIndex = 1;
            btn_sumar.Text = "Sumar";
            btn_sumar.UseVisualStyleBackColor = true;
            btn_sumar.Click += btn_sumar_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(182, 118);
            label2.Name = "label2";
            label2.Size = new Size(60, 15);
            label2.TabIndex = 2;
            label2.Text = "Numero 1";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(182, 164);
            label3.Name = "label3";
            label3.Size = new Size(60, 15);
            label3.TabIndex = 3;
            label3.Text = "Numero 2";
            // 
            // txt_num1
            // 
            txt_num1.Location = new Point(276, 115);
            txt_num1.Name = "txt_num1";
            txt_num1.Size = new Size(100, 23);
            txt_num1.TabIndex = 4;
            // 
            // txt_num2
            // 
            txt_num2.Location = new Point(276, 161);
            txt_num2.Name = "txt_num2";
            txt_num2.Size = new Size(100, 23);
            txt_num2.TabIndex = 5;
            // 
            // resultado
            // 
            resultado.AutoSize = true;
            resultado.BackColor = Color.FromArgb(0, 192, 0);
            resultado.Location = new Point(234, 328);
            resultado.Name = "resultado";
            resultado.Size = new Size(69, 15);
            resultado.TabIndex = 6;
            resultado.Text = "RESULTADO";
            resultado.Visible = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(resultado);
            Controls.Add(txt_num2);
            Controls.Add(txt_num1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btn_sumar);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btn_sumar;
        private Label label2;
        private Label label3;
        private TextBox txt_num1;
        private TextBox txt_num2;
        private Label resultado;
    }
}
