namespace Ejercicios_C_.recursividad
{
    partial class _03
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar cualquier recurso que se esté utilizando.
        /// </summary>
        /// <param name="disposing">True si los recursos administrados deben eliminarse; en caso contrario, False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        private void InitializeComponent()
        {
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.txtCantidadDivisores = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.lblNumero = new System.Windows.Forms.Label();
            this.lblCantidadDivisores = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(220, 50);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(100, 20);
            this.txtNumero.TabIndex = 0;
            // 
            // txtCantidadDivisores
            // 
            this.txtCantidadDivisores.Location = new System.Drawing.Point(220, 90);
            this.txtCantidadDivisores.Name = "txtCantidadDivisores";
            this.txtCantidadDivisores.ReadOnly = true;
            this.txtCantidadDivisores.Size = new System.Drawing.Size(100, 20);
            this.txtCantidadDivisores.TabIndex = 1;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(150, 130);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(100, 30);
            this.btnCalcular.TabIndex = 2;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Location = new System.Drawing.Point(50, 50);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(52, 13);
            this.lblNumero.TabIndex = 3;
            this.lblNumero.Text = "Número:";
            // 
            // lblCantidadDivisores
            // 
            this.lblCantidadDivisores.AutoSize = true;
            this.lblCantidadDivisores.Location = new System.Drawing.Point(50, 90);
            this.lblCantidadDivisores.Name = "lblCantidadDivisores";
            this.lblCantidadDivisores.Size = new System.Drawing.Size(119, 13);
            this.lblCantidadDivisores.TabIndex = 4;
            this.lblCantidadDivisores.Text = "Cantidad de divisores:";
            // 
            // frm03_02
            // 
            this.ClientSize = new System.Drawing.Size(450, 300);
            this.Controls.Add(this.lblCantidadDivisores);
            this.Controls.Add(this.lblNumero);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtCantidadDivisores);
            this.Controls.Add(this.txtNumero);
            this.Name = "frm03_02";
            this.Text = "Contar Divisores";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.TextBox txtCantidadDivisores;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.Label lblCantidadDivisores;
    }
}
