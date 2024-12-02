namespace Ejercicios_C_.condicionales
{
    partial class _02
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblUnidades = new System.Windows.Forms.Label();
            this.lblImporte = new System.Windows.Forms.Label();
            this.lblDescuento = new System.Windows.Forms.Label();
            this.lblTotalPagar = new System.Windows.Forms.Label();
            this.lblCaramelos = new System.Windows.Forms.Label();
            this.txtUnidades = new System.Windows.Forms.TextBox();
            this.txtImporte = new System.Windows.Forms.TextBox();
            this.txtDescuento = new System.Windows.Forms.TextBox();
            this.txtTotalPagar = new System.Windows.Forms.TextBox();
            this.txtCaramelos = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblUnidades
            // 
            this.lblUnidades.AutoSize = true;
            this.lblUnidades.Location = new System.Drawing.Point(50, 50);
            this.lblUnidades.Name = "lblUnidades";
            this.lblUnidades.Size = new System.Drawing.Size(138, 15);
            this.lblUnidades.TabIndex = 0;
            this.lblUnidades.Text = "Cantidad de Unidades:";
            // 
            // lblImporte
            // 
            this.lblImporte.AutoSize = true;
            this.lblImporte.Location = new System.Drawing.Point(50, 100);
            this.lblImporte.Name = "lblImporte";
            this.lblImporte.Size = new System.Drawing.Size(50, 15);
            this.lblImporte.TabIndex = 1;
            this.lblImporte.Text = "Importe:";
            // 
            // lblDescuento
            // 
            this.lblDescuento.AutoSize = true;
            this.lblDescuento.Location = new System.Drawing.Point(50, 150);
            this.lblDescuento.Name = "lblDescuento";
            this.lblDescuento.Size = new System.Drawing.Size(67, 15);
            this.lblDescuento.TabIndex = 2;
            this.lblDescuento.Text = "Descuento:";
            // 
            // lblTotalPagar
            // 
            this.lblTotalPagar.AutoSize = true;
            this.lblTotalPagar.Location = new System.Drawing.Point(50, 200);
            this.lblTotalPagar.Name = "lblTotalPagar";
            this.lblTotalPagar.Size = new System.Drawing.Size(84, 15);
            this.lblTotalPagar.TabIndex = 3;
            this.lblTotalPagar.Text = "Total a Pagar:";
            // 
            // lblCaramelos
            // 
            this.lblCaramelos.AutoSize = true;
            this.lblCaramelos.Location = new System.Drawing.Point(50, 250);
            this.lblCaramelos.Name = "lblCaramelos";
            this.lblCaramelos.Size = new System.Drawing.Size(65, 15);
            this.lblCaramelos.TabIndex = 4;
            this.lblCaramelos.Text = "Caramelos:";
            // 
            // txtUnidades
            // 
            this.txtUnidades.Location = new System.Drawing.Point(220, 50);
            this.txtUnidades.Name = "txtUnidades";
            this.txtUnidades.Size = new System.Drawing.Size(100, 23);
            this.txtUnidades.TabIndex = 5;
            // 
            // txtImporte
            // 
            this.txtImporte.Location = new System.Drawing.Point(220, 100);
            this.txtImporte.Name = "txtImporte";
            this.txtImporte.ReadOnly = true;
            this.txtImporte.Size = new System.Drawing.Size(100, 23);
            this.txtImporte.TabIndex = 6;
            // 
            // txtDescuento
            // 
            this.txtDescuento.Location = new System.Drawing.Point(220, 150);
            this.txtDescuento.Name = "txtDescuento";
            this.txtDescuento.ReadOnly = true;
            this.txtDescuento.Size = new System.Drawing.Size(100, 23);
            this.txtDescuento.TabIndex = 7;
            // 
            // txtTotalPagar
            // 
            this.txtTotalPagar.Location = new System.Drawing.Point(220, 200);
            this.txtTotalPagar.Name = "txtTotalPagar";
            this.txtTotalPagar.ReadOnly = true;
            this.txtTotalPagar.Size = new System.Drawing.Size(100, 23);
            this.txtTotalPagar.TabIndex = 8;
            // 
            // txtCaramelos
            // 
            this.txtCaramelos.Location = new System.Drawing.Point(220, 250);
            this.txtCaramelos.Name = "txtCaramelos";
            this.txtCaramelos.ReadOnly = true;
            this.txtCaramelos.Size = new System.Drawing.Size(100, 23);
            this.txtCaramelos.TabIndex = 9;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(150, 300);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(100, 30);
            this.btnCalcular.TabIndex = 10;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // _02
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 370);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtCaramelos);
            this.Controls.Add(this.txtTotalPagar);
            this.Controls.Add(this.txtDescuento);
            this.Controls.Add(this.txtImporte);
            this.Controls.Add(this.txtUnidades);
            this.Controls.Add(this.lblCaramelos);
            this.Controls.Add(this.lblTotalPagar);
            this.Controls.Add(this.lblDescuento);
            this.Controls.Add(this.lblImporte);
            this.Controls.Add(this.lblUnidades);
            this.Name = "_02";
            this.Text = "Ejercicio 02";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblUnidades;
        private System.Windows.Forms.Label lblImporte;
        private System.Windows.Forms.Label lblDescuento;
        private System.Windows.Forms.Label lblTotalPagar;
        private System.Windows.Forms.Label lblCaramelos;
        private System.Windows.Forms.TextBox txtUnidades;
        private System.Windows.Forms.TextBox txtImporte;
        private System.Windows.Forms.TextBox txtDescuento;
        private System.Windows.Forms.TextBox txtTotalPagar;
        private System.Windows.Forms.TextBox txtCaramelos;
        private System.Windows.Forms.Button btnCalcular;
    }
}
