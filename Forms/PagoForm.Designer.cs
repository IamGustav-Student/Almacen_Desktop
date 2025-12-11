namespace AlmacenDesktop.Forms
{
    partial class PagoForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PagoForm));
            label1 = new Label();
            numMonto = new NumericUpDown();
            btnAceptar = new Button();
            btnCancelar = new Button();
            ((System.ComponentModel.ISupportInitialize)numMonto).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(30, 20);
            label1.Name = "label1";
            label1.Size = new Size(209, 21);
            label1.TabIndex = 3;
            label1.Text = "Ingrese el monto a pagar ($):";
            // 
            // numMonto
            // 
            numMonto.DecimalPlaces = 2;
            numMonto.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            numMonto.Location = new Point(30, 50);
            numMonto.Maximum = new decimal(new int[] { 10000000, 0, 0, 0 });
            numMonto.Name = "numMonto";
            numMonto.Size = new Size(220, 32);
            numMonto.TabIndex = 0;
            numMonto.TextAlign = HorizontalAlignment.Right;
            // 
            // btnAceptar
            // 
            btnAceptar.BackColor = Color.SeaGreen;
            btnAceptar.DialogResult = DialogResult.OK;
            btnAceptar.FlatStyle = FlatStyle.Flat;
            btnAceptar.ForeColor = Color.White;
            btnAceptar.Location = new Point(30, 100);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(100, 35);
            btnAceptar.TabIndex = 1;
            btnAceptar.Text = "ACEPTAR";
            btnAceptar.UseVisualStyleBackColor = false;
            // 
            // btnCancelar
            // 
            btnCancelar.DialogResult = DialogResult.Cancel;
            btnCancelar.Location = new Point(150, 100);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(100, 35);
            btnCancelar.TabIndex = 2;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // PagoForm
            // 
            AcceptButton = btnAceptar;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnCancelar;
            ClientSize = new Size(284, 161);
            Controls.Add(btnCancelar);
            Controls.Add(btnAceptar);
            Controls.Add(numMonto);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "PagoForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Registrar Pago";
            ((System.ComponentModel.ISupportInitialize)numMonto).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numMonto;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
    }
}