namespace AlmacenDesktop.Forms
{
    partial class VentasForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VentasForm));
            lblTitulo = new Label();
            groupBox1 = new GroupBox();
            btnVentas = new Button();
            btnFiados = new Button();
            cboMetodoPago = new ComboBox();
            label4 = new Label();
            cboClientes = new ComboBox();
            label1 = new Label();
            groupBox2 = new GroupBox();
            txtEscanear = new TextBox();
            labelEscanear = new Label();
            btnAgregar = new Button();
            numCantidad = new NumericUpDown();
            label3 = new Label();
            cboProductos = new ComboBox();
            label2 = new Label();
            dgvCarrito = new DataGridView();
            btnFinalizar = new Button();
            lblTotal = new Label();
            groupBox3 = new GroupBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numCantidad).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvCarrito).BeginInit();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTitulo.Location = new Point(12, 9);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(145, 30);
            lblTitulo.TabIndex = 7;
            lblTitulo.Text = "Nueva Venta";
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.Controls.Add(btnVentas);
            groupBox1.Controls.Add(btnFiados);
            groupBox1.Controls.Add(cboMetodoPago);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(cboClientes);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(18, 50);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1254, 225);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Datos de Pago";
            // 
            // btnVentas
            // 
            btnVentas.AutoSize = true;
            btnVentas.BackColor = Color.Green;
            btnVentas.FlatStyle = FlatStyle.Flat;
            btnVentas.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnVentas.ForeColor = Color.White;
            btnVentas.Location = new Point(1094, 44);
            btnVentas.Name = "btnVentas";
            btnVentas.Size = new Size(120, 30);
            btnVentas.TabIndex = 8;
            btnVentas.Text = "Ventas";
            btnVentas.UseVisualStyleBackColor = false;
            btnVentas.Click += btnVentas_Click;
            // 
            // btnFiados
            // 
            btnFiados.AutoSize = true;
            btnFiados.BackColor = Color.Green;
            btnFiados.FlatStyle = FlatStyle.Flat;
            btnFiados.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnFiados.ForeColor = Color.White;
            btnFiados.Location = new Point(941, 44);
            btnFiados.Name = "btnFiados";
            btnFiados.Size = new Size(120, 30);
            btnFiados.TabIndex = 7;
            btnFiados.Text = "Fiado";
            btnFiados.UseVisualStyleBackColor = false;
            btnFiados.Click += btnFiados_Click;
            // 
            // cboMetodoPago
            // 
            cboMetodoPago.DropDownStyle = ComboBoxStyle.DropDownList;
            cboMetodoPago.FormattingEnabled = true;
            cboMetodoPago.Location = new Point(110, 27);
            cboMetodoPago.Name = "cboMetodoPago";
            cboMetodoPago.Size = new Size(150, 23);
            cboMetodoPago.TabIndex = 0;
            cboMetodoPago.SelectedIndexChanged += cboMetodoPago_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label4.Location = new Point(20, 30);
            label4.Name = "label4";
            label4.Size = new Size(84, 15);
            label4.TabIndex = 1;
            label4.Text = "Método Pago:";
            // 
            // cboClientes
            // 
            cboClientes.DropDownStyle = ComboBoxStyle.DropDownList;
            cboClientes.FormattingEnabled = true;
            cboClientes.Location = new Point(330, 27);
            cboClientes.Name = "cboClientes";
            cboClientes.Size = new Size(400, 23);
            cboClientes.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(280, 30);
            label1.Name = "label1";
            label1.Size = new Size(47, 15);
            label1.TabIndex = 2;
            label1.Text = "Cliente:";
            // 
            // groupBox2
            // 
            groupBox2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox2.Controls.Add(txtEscanear);
            groupBox2.Controls.Add(labelEscanear);
            groupBox2.Controls.Add(btnAgregar);
            groupBox2.Controls.Add(numCantidad);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(cboProductos);
            groupBox2.Controls.Add(label2);
            groupBox2.Location = new Point(18, 130);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1254, 255);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Agregar Producto";
            // 
            // txtEscanear
            // 
            txtEscanear.BackColor = Color.LightCyan;
            txtEscanear.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            txtEscanear.Location = new Point(140, 22);
            txtEscanear.Name = "txtEscanear";
            txtEscanear.Size = new Size(200, 27);
            txtEscanear.TabIndex = 0;
            txtEscanear.TextChanged += txtEscanear_TextChanged;
            txtEscanear.KeyPress += txtEscanear_KeyPress;
            // 
            // labelEscanear
            // 
            labelEscanear.AutoSize = true;
            labelEscanear.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            labelEscanear.ForeColor = Color.DarkBlue;
            labelEscanear.Location = new Point(15, 25);
            labelEscanear.Name = "labelEscanear";
            labelEscanear.Size = new Size(119, 15);
            labelEscanear.TabIndex = 1;
            labelEscanear.Text = "ESCANEAR CÓDIGO:";
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = Color.SteelBlue;
            btnAgregar.FlatStyle = FlatStyle.Flat;
            btnAgregar.ForeColor = Color.White;
            btnAgregar.Location = new Point(550, 55);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(120, 30);
            btnAgregar.TabIndex = 4;
            btnAgregar.Text = "Agregar Manual";
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // numCantidad
            // 
            numCantidad.Location = new Point(460, 60);
            numCantidad.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numCantidad.Name = "numCantidad";
            numCantidad.Size = new Size(60, 23);
            numCantidad.TabIndex = 3;
            numCantidad.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(395, 63);
            label3.Name = "label3";
            label3.Size = new Size(58, 15);
            label3.TabIndex = 5;
            label3.Text = "Cantidad:";
            // 
            // cboProductos
            // 
            cboProductos.DropDownStyle = ComboBoxStyle.DropDownList;
            cboProductos.FormattingEnabled = true;
            cboProductos.Location = new Point(80, 60);
            cboProductos.Name = "cboProductos";
            cboProductos.Size = new Size(300, 23);
            cboProductos.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(15, 63);
            label2.Name = "label2";
            label2.Size = new Size(62, 15);
            label2.TabIndex = 6;
            label2.Text = "O Manual:";
            // 
            // dgvCarrito
            // 
            dgvCarrito.AllowUserToAddRows = false;
            dgvCarrito.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvCarrito.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCarrito.BackgroundColor = Color.White;
            dgvCarrito.Location = new Point(18, 250);
            dgvCarrito.Name = "dgvCarrito";
            dgvCarrito.ReadOnly = true;
            dgvCarrito.Size = new Size(1254, 355);
            dgvCarrito.TabIndex = 3;
            // 
            // btnFinalizar
            // 
            btnFinalizar.BackColor = Color.DarkGreen;
            btnFinalizar.Dock = DockStyle.Bottom;
            btnFinalizar.FlatStyle = FlatStyle.Flat;
            btnFinalizar.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnFinalizar.ForeColor = Color.White;
            btnFinalizar.Location = new Point(3, 106);
            btnFinalizar.Name = "btnFinalizar";
            btnFinalizar.Size = new Size(1248, 40);
            btnFinalizar.TabIndex = 5;
            btnFinalizar.Text = "FINALIZAR VENTA";
            btnFinalizar.UseVisualStyleBackColor = false;
            btnFinalizar.Click += btnFinalizar_Click;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.BackColor = Color.Gold;
            lblTotal.Dock = DockStyle.Bottom;
            lblTotal.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotal.Location = new Point(3, 69);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(185, 37);
            lblTotal.TabIndex = 8;
            lblTotal.Text = "Total a Pagar";
            lblTotal.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // groupBox3
            // 
            groupBox3.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox3.Controls.Add(lblTotal);
            groupBox3.Controls.Add(btnFinalizar);
            groupBox3.Location = new Point(18, 604);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(1254, 149);
            groupBox3.TabIndex = 9;
            groupBox3.TabStop = false;
            groupBox3.Text = "Finalizar Venta";
            // 
            // VentasForm
            // 
            ClientSize = new Size(1345, 765);
            Controls.Add(groupBox3);
            Controls.Add(dgvCarrito);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(lblTitulo);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "VentasForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Punto de Venta";
            WindowState = FormWindowState.Maximized;
            Load += VentasForm_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numCantidad).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvCarrito).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cboClientes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.NumericUpDown numCantidad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboProductos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvCarrito;
        private System.Windows.Forms.Button btnFinalizar;
        private System.Windows.Forms.TextBox txtEscanear;
        private System.Windows.Forms.Label labelEscanear;

        // Controles Nuevos
        private System.Windows.Forms.ComboBox cboMetodoPago;
        private System.Windows.Forms.Label label4;
        private Label lblTotal;
        private GroupBox groupBox3;
        private Button btnVentas;
        private Button btnFiados;
    }
}