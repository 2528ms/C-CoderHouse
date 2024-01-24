namespace Clase9_ADOnet
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
            dataGridView1 = new DataGridView();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            dataGridView2 = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            Nombre = new DataGridViewTextBoxColumn();
            Apellido = new DataGridViewTextBoxColumn();
            Usuario = new DataGridViewTextBoxColumn();
            Contraseña = new DataGridViewTextBoxColumn();
            Mail = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(47, 43);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(936, 344);
            dataGridView1.TabIndex = 0;
            // 
            // dataGridView2
            // 
            dataGridView2.AllowUserToAddRows = false;
            dataGridView2.AllowUserToDeleteRows = false;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Columns.AddRange(new DataGridViewColumn[] { Id, Nombre, Apellido, Usuario, Contraseña, Mail });
            dataGridView2.Location = new Point(47, 419);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.ReadOnly = true;
            dataGridView2.RowTemplate.Height = 25;
            dataGridView2.Size = new Size(936, 150);
            dataGridView2.TabIndex = 1;
            // 
            // Id
            // 
            Id.DataPropertyName = "Id";
            Id.HeaderText = "Id";
            Id.Name = "Id";
            Id.ReadOnly = true;
            // 
            // Nombre
            // 
            Nombre.DataPropertyName = "Nombre";
            Nombre.HeaderText = "Nombre";
            Nombre.Name = "Nombre";
            Nombre.ReadOnly = true;
            // 
            // Apellido
            // 
            Apellido.DataPropertyName = "Apellido";
            Apellido.HeaderText = "Apellido";
            Apellido.Name = "Apellido";
            Apellido.ReadOnly = true;
            // 
            // Usuario
            // 
            Usuario.DataPropertyName = "NombreUsuario";
            Usuario.HeaderText = "Usuario";
            Usuario.Name = "Usuario";
            Usuario.ReadOnly = true;
            // 
            // Contraseña
            // 
            Contraseña.DataPropertyName = "Contraseña";
            Contraseña.HeaderText = "Contraseña";
            Contraseña.Name = "Contraseña";
            Contraseña.ReadOnly = true;
            // 
            // Mail
            // 
            Mail.DataPropertyName = "Mail";
            Mail.HeaderText = "Mail";
            Mail.Name = "Mail";
            Mail.ReadOnly = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1017, 601);
            Controls.Add(dataGridView2);
            Controls.Add(dataGridView1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load_1;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private DataGridView dataGridView2;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Apellido;
        private DataGridViewTextBoxColumn Usuario;
        private DataGridViewTextBoxColumn Contraseña;
        private DataGridViewTextBoxColumn Mail;
    }
}
