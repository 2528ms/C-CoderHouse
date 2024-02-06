namespace CRUD_EntityFramework
{
    partial class FrmView
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
            btnListar = new Button();
            dgvDatos = new DataGridView();
            btnProducto = new Button();
            btnVenta = new Button();
            btnProductoVendido = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvDatos).BeginInit();
            SuspendLayout();
            // 
            // btnListar
            // 
            btnListar.Location = new Point(23, 29);
            btnListar.Name = "btnListar";
            btnListar.Size = new Size(104, 46);
            btnListar.TabIndex = 0;
            btnListar.Text = "Usuario";
            btnListar.UseVisualStyleBackColor = true;
            btnListar.Click += btnListar_Click;
            // 
            // dgvDatos
            // 
            dgvDatos.AllowUserToAddRows = false;
            dgvDatos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDatos.Location = new Point(192, 12);
            dgvDatos.MultiSelect = false;
            dgvDatos.Name = "dgvDatos";
            dgvDatos.ReadOnly = true;
            dgvDatos.RowTemplate.Height = 25;
            dgvDatos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDatos.Size = new Size(757, 389);
            dgvDatos.TabIndex = 1;
            // 
            // btnProducto
            // 
            btnProducto.Location = new Point(23, 110);
            btnProducto.Name = "btnProducto";
            btnProducto.Size = new Size(104, 46);
            btnProducto.TabIndex = 2;
            btnProducto.Text = "Producto";
            btnProducto.UseVisualStyleBackColor = true;
            btnProducto.Click += btnProducto_Click;
            // 
            // btnVenta
            // 
            btnVenta.Location = new Point(23, 196);
            btnVenta.Name = "btnVenta";
            btnVenta.Size = new Size(104, 46);
            btnVenta.TabIndex = 3;
            btnVenta.Text = "Venta";
            btnVenta.UseVisualStyleBackColor = true;
            btnVenta.Click += btnVenta_Click;
            // 
            // btnProductoVendido
            // 
            btnProductoVendido.Location = new Point(23, 291);
            btnProductoVendido.Name = "btnProductoVendido";
            btnProductoVendido.Size = new Size(112, 46);
            btnProductoVendido.TabIndex = 4;
            btnProductoVendido.Text = "ProductoVendido";
            btnProductoVendido.UseVisualStyleBackColor = true;
            btnProductoVendido.Click += btnProductoVendido_Click;
            // 
            // FrmView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(986, 450);
            ControlBox = false;
            Controls.Add(btnProductoVendido);
            Controls.Add(btnVenta);
            Controls.Add(btnProducto);
            Controls.Add(dgvDatos);
            Controls.Add(btnListar);
            MaximizeBox = false;
            Name = "FrmView";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvDatos).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnListar;
        private DataGridView dgvDatos;
        private Button btnProducto;
        private Button btnVenta;
        private Button btnProductoVendido;
    }
}
