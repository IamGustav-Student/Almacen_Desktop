namespace AlmacenDesktop.Forms
{
    partial class ReporteFiadosForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReporteFiadosForm));
            panelIzq = new Panel();
            btnRegistrarPago = new Button();
            lblSaldo = new Label();
            label2 = new Label();
            cboClientes = new ComboBox();
            label1 = new Label();
            dgvMovimientos = new DataGridView();
            lblTituloGrilla = new Label();
            panelIzq.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMovimientos).BeginInit();
            SuspendLayout();
            // 
            // panelIzq
            // 
            panelIzq.BackColor = Color.WhiteSmoke;
            panelIzq.Controls.Add(btnRegistrarPago);
            panelIzq.Controls.Add(lblSaldo);
            panelIzq.Controls.Add(label2);
            panelIzq.Controls.Add(cboClientes);
            panelIzq.Controls.Add(label1);
            panelIzq.Dock = DockStyle.Left;
            panelIzq.Location = new Point(0, 0);
            panelIzq.Name = "panelIzq";
            panelIzq.Size = new Size(300, 500);
            panelIzq.TabIndex = 0;
            // 
            // btnRegistrarPago
            // 
            btnRegistrarPago.BackColor = Color.SeaGreen;
            btnRegistrarPago.Enabled = false;
            btnRegistrarPago.FlatStyle = FlatStyle.Flat;
            btnRegistrarPago.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnRegistrarPago.ForeColor = Color.White;
            btnRegistrarPago.Location = new Point(20, 250);
            btnRegistrarPago.Name = "btnRegistrarPago";
            btnRegistrarPago.Size = new Size(250, 50);
            btnRegistrarPago.TabIndex = 1;
            btnRegistrarPago.Text = "REGISTRAR PAGO";
            btnRegistrarPago.UseVisualStyleBackColor = false;
            btnRegistrarPago.Click += btnRegistrarPago_Click;
            // 
            // lblSaldo
            // 
            lblSaldo.AutoSize = true;
            lblSaldo.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            lblSaldo.ForeColor = Color.Firebrick;
            lblSaldo.Location = new Point(20, 150);
            lblSaldo.Name = "lblSaldo";
            lblSaldo.Size = new Size(110, 45);
            lblSaldo.TabIndex = 2;
            lblSaldo.Text = "$ 0.00";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(20, 120);
            label2.Name = "label2";
            label2.Size = new Size(155, 21);
            label2.TabIndex = 3;
            label2.Text = "Saldo Deudor Actual:";
            // 
            // cboClientes
            // 
            cboClientes.DropDownStyle = ComboBoxStyle.DropDownList;
            cboClientes.FormattingEnabled = true;
            cboClientes.Location = new Point(20, 50);
            cboClientes.Name = "cboClientes";
            cboClientes.Size = new Size(250, 23);
            cboClientes.TabIndex = 0;
            cboClientes.SelectedIndexChanged += cboClientes_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(20, 30);
            label1.Name = "label1";
            label1.Size = new Size(106, 15);
            label1.TabIndex = 4;
            label1.Text = "Seleccione Cliente:";
            // 
            // dgvMovimientos
            // 
            dgvMovimientos.AllowUserToAddRows = false;
            dgvMovimientos.AllowUserToDeleteRows = false;
            dgvMovimientos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvMovimientos.BackgroundColor = Color.White;
            dgvMovimientos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMovimientos.Dock = DockStyle.Fill;
            dgvMovimientos.Location = new Point(300, 40);
            dgvMovimientos.Name = "dgvMovimientos";
            dgvMovimientos.ReadOnly = true;
            dgvMovimientos.Size = new Size(500, 460);
            dgvMovimientos.TabIndex = 1;
            // 
            // lblTituloGrilla
            // 
            lblTituloGrilla.BackColor = Color.White;
            lblTituloGrilla.Dock = DockStyle.Top;
            lblTituloGrilla.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblTituloGrilla.Location = new Point(300, 0);
            lblTituloGrilla.Name = "lblTituloGrilla";
            lblTituloGrilla.Padding = new Padding(10);
            lblTituloGrilla.Size = new Size(500, 40);
            lblTituloGrilla.TabIndex = 2;
            lblTituloGrilla.Text = "Historial de Movimientos (Fiados y Pagos)";
            // 
            // ReporteFiadosForm
            // 
            ClientSize = new Size(800, 500);
            Controls.Add(dgvMovimientos);
            Controls.Add(lblTituloGrilla);
            Controls.Add(panelIzq);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "ReporteFiadosForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Estado de Cuenta Corriente";
            Load += ReporteFiadosForm_Load;
            panelIzq.ResumeLayout(false);
            panelIzq.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMovimientos).EndInit();
            ResumeLayout(false);
        }

        private System.Windows.Forms.Panel panelIzq;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboClientes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblSaldo;
        private System.Windows.Forms.Button btnRegistrarPago;
        private System.Windows.Forms.DataGridView dgvMovimientos;
        private System.Windows.Forms.Label lblTituloGrilla;
    }
}