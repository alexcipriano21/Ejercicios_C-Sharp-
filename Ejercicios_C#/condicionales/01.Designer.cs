namespace Ejercicios_C_.condicionales
{
    partial class _01
    {
        private System.ComponentModel.IContainer components = null;

        // Disposición de controles
        private System.Windows.Forms.TextBox txtUnidades;
        private System.Windows.Forms.TextBox txtImporteCompra;
        private System.Windows.Forms.TextBox txtDescuento;
        private System.Windows.Forms.TextBox txtTotalPagar;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label lblUnidades;
        private System.Windows.Forms.Label lblImporteCompra;
        private System.Windows.Forms.Label lblDescuento;
        private System.Windows.Forms.Label lblTotalPagar;

        /// <summary>
        /// Liberar recursos.
        /// </summary>
        /// <param name="disposing"></param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        /// <summary>
        /// Inicializa los componentes del formulario.
        /// </summary>
        private void InitializeComponent()
        {
            txtUnidades = new TextBox();
            txtImporteCompra = new TextBox();
            txtDescuento = new TextBox();
            txtTotalPagar = new TextBox();
            btnCalcular = new Button();
            lblUnidades = new Label();
            lblImporteCompra = new Label();
            lblDescuento = new Label();
            lblTotalPagar = new Label();
            SuspendLayout();
            // 
            // txtUnidades
            // 
            txtUnidades.Location = new Point(213, 41);
            txtUnidades.Name = "txtUnidades";
            txtUnidades.Size = new Size(100, 23);
            txtUnidades.TabIndex = 4;
            // 
            // txtImporteCompra
            // 
            txtImporteCompra.Location = new Point(213, 121);
            txtImporteCompra.Name = "txtImporteCompra";
            txtImporteCompra.ReadOnly = true;
            txtImporteCompra.Size = new Size(100, 23);
            txtImporteCompra.TabIndex = 5;
            // 
            // txtDescuento
            // 
            txtDescuento.Location = new Point(213, 161);
            txtDescuento.Name = "txtDescuento";
            txtDescuento.ReadOnly = true;
            txtDescuento.Size = new Size(100, 23);
            txtDescuento.TabIndex = 6;
            // 
            // txtTotalPagar
            // 
            txtTotalPagar.Location = new Point(213, 201);
            txtTotalPagar.Name = "txtTotalPagar";
            txtTotalPagar.ReadOnly = true;
            txtTotalPagar.Size = new Size(100, 23);
            txtTotalPagar.TabIndex = 7;
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(143, 261);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(100, 30);
            btnCalcular.TabIndex = 8;
            btnCalcular.Text = "Calcular";
            btnCalcular.Click += BtnCalcular_Click;
            // 
            // lblUnidades
            // 
            lblUnidades.Location = new Point(43, 41);
            lblUnidades.Name = "lblUnidades";
            lblUnidades.Size = new Size(150, 30);
            lblUnidades.TabIndex = 0;
            lblUnidades.Text = "Cantidad de Unidades:";
            // 
            // lblImporteCompra
            // 
            lblImporteCompra.Location = new Point(43, 121);
            lblImporteCompra.Name = "lblImporteCompra";
            lblImporteCompra.Size = new Size(150, 30);
            lblImporteCompra.TabIndex = 1;
            lblImporteCompra.Text = "Importe de Compra:";
            // 
            // lblDescuento
            // 
            lblDescuento.Location = new Point(43, 161);
            lblDescuento.Name = "lblDescuento";
            lblDescuento.Size = new Size(150, 30);
            lblDescuento.TabIndex = 2;
            lblDescuento.Text = "Descuento:";
            // 
            // lblTotalPagar
            // 
            lblTotalPagar.Location = new Point(43, 201);
            lblTotalPagar.Name = "lblTotalPagar";
            lblTotalPagar.Size = new Size(150, 30);
            lblTotalPagar.TabIndex = 3;
            lblTotalPagar.Text = "Total a Pagar:";
            // 
            // _01
            // 
            ClientSize = new Size(354, 347);
            Controls.Add(lblUnidades);
            Controls.Add(lblImporteCompra);
            Controls.Add(lblDescuento);
            Controls.Add(lblTotalPagar);
            Controls.Add(txtUnidades);
            Controls.Add(txtImporteCompra);
            Controls.Add(txtDescuento);
            Controls.Add(txtTotalPagar);
            Controls.Add(btnCalcular);
            Name = "_01";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ejercicio 01";
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
