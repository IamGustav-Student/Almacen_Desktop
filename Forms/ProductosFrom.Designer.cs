namespace AlmacenDesktop.Forms
{
    partial class ProductosForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductosForm));
            dgvProductos = new DataGridView();
            panelFormulario = new Panel();
            btnLimpiar = new Button();
            btnEliminar = new Button();
            btnGuardar = new Button();
            numStock = new NumericUpDown();
            label4 = new Label();
            numPrecio = new NumericUpDown();
            label3 = new Label();
            txtCodigo = new TextBox();
            label2 = new Label();
            txtNombre = new TextBox();
            label1 = new Label();
            lblTitulo = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvProductos).BeginInit();
            panelFormulario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numStock).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numPrecio).BeginInit();
            SuspendLayout();
            // 
            // dgvProductos
            // 
            dgvProductos.AllowUserToAddRows = false;
            dgvProductos.AllowUserToDeleteRows = false;
            dgvProductos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvProductos.BackgroundColor = Color.White;
            dgvProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProductos.Dock = DockStyle.Right;
            dgvProductos.Location = new Point(300, 0);
            dgvProductos.MultiSelect = false;
            dgvProductos.Name = "dgvProductos";
            dgvProductos.ReadOnly = true;
            dgvProductos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProductos.Size = new Size(500, 450);
            dgvProductos.TabIndex = 1;
            dgvProductos.SelectionChanged += dgvProductos_SelectionChanged;
            // 
            // panelFormulario
            // 
            panelFormulario.BackColor = Color.WhiteSmoke;
            panelFormulario.Controls.Add(btnLimpiar);
            panelFormulario.Controls.Add(btnEliminar);
            panelFormulario.Controls.Add(btnGuardar);
            panelFormulario.Controls.Add(numStock);
            panelFormulario.Controls.Add(label4);
            panelFormulario.Controls.Add(numPrecio);
            panelFormulario.Controls.Add(label3);
            panelFormulario.Controls.Add(txtCodigo);
            panelFormulario.Controls.Add(label2);
            panelFormulario.Controls.Add(txtNombre);
            panelFormulario.Controls.Add(label1);
            panelFormulario.Controls.Add(lblTitulo);
            panelFormulario.Dock = DockStyle.Left;
            panelFormulario.Location = new Point(0, 0);
            panelFormulario.Name = "panelFormulario";
            panelFormulario.Size = new Size(300, 450);
            panelFormulario.TabIndex = 0;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(15, 360);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(260, 30);
            btnLimpiar.TabIndex = 7;
            btnLimpiar.Text = "Limpiar Formulario (Nuevo)";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.Firebrick;
            btnEliminar.FlatStyle = FlatStyle.Flat;
            btnEliminar.ForeColor = Color.White;
            btnEliminar.Location = new Point(15, 310);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(260, 40);
            btnEliminar.TabIndex = 6;
            btnEliminar.Text = "ELIMINAR SELECCIONADO";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.ForestGreen;
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.ForeColor = Color.White;
            btnGuardar.Location = new Point(15, 260);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(260, 40);
            btnGuardar.TabIndex = 5;
            btnGuardar.Text = "GUARDAR / ACTUALIZAR";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // numStock
            // 
            numStock.Location = new Point(155, 210);
            numStock.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            numStock.Name = "numStock";
            numStock.Size = new Size(120, 23);
            numStock.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(155, 190);
            label4.Name = "label4";
            label4.Size = new Size(73, 15);
            label4.TabIndex = 8;
            label4.Text = "Stock Inicial:";
            // 
            // numPrecio
            // 
            numPrecio.DecimalPlaces = 2;
            numPrecio.Location = new Point(15, 210);
            numPrecio.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            numPrecio.Name = "numPrecio";
            numPrecio.Size = new Size(120, 23);
            numPrecio.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(15, 190);
            label3.Name = "label3";
            label3.Size = new Size(60, 15);
            label3.TabIndex = 9;
            label3.Text = "Precio ($):";
            // 
            // txtCodigo
            // 
            txtCodigo.BackColor = Color.Azure;
            txtCodigo.Location = new Point(15, 150);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(260, 23);
            txtCodigo.TabIndex = 0;
            txtCodigo.KeyPress += txtCodigo_KeyPress;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.ForeColor = Color.DarkBlue;
            label2.Location = new Point(15, 130);
            label2.Name = "label2";
            label2.Size = new Size(188, 15);
            label2.TabIndex = 10;
            label2.Text = "Código de Barras (Escanear aquí):";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(15, 90);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(260, 23);
            txtNombre.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(15, 70);
            label1.Name = "label1";
            label1.Size = new Size(125, 15);
            label1.TabIndex = 11;
            label1.Text = "Nombre del Producto:";
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblTitulo.Location = new Point(12, 20);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(204, 25);
            lblTitulo.TabIndex = 12;
            lblTitulo.Text = "Gestión de Productos";
            // 
            // ProductosForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvProductos);
            Controls.Add(panelFormulario);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "ProductosForm";
            Text = "Administración de Productos";
            WindowState = FormWindowState.Maximized;
            Load += ProductosForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvProductos).EndInit();
            panelFormulario.ResumeLayout(false);
            panelFormulario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numStock).EndInit();
            ((System.ComponentModel.ISupportInitialize)numPrecio).EndInit();
            ResumeLayout(false);
        }

        private System.Windows.Forms.DataGridView dgvProductos;
        private System.Windows.Forms.Panel panelFormulario;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numPrecio;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numStock;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnLimpiar;
    }
}