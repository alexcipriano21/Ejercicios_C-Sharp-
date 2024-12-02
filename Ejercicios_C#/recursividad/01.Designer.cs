namespace Ejercicios_C_.recursividad
{
    partial class _01
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
            this.txtDividendo = new System.Windows.Forms.TextBox();
            this.txtDivisor = new System.Windows.Forms.TextBox();
            this.txtCociente = new System.Windows.Forms.TextBox();
            this.txtResto = new System.Windows.Forms.TextBox();
            this.lblDividendo = new System.Windows.Forms.Label();
            this.lblDivisor = new System.Windows.Forms.Label();
            this.lblCociente = new System.Windows.Forms.Label();
            this.lblResto = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtDividendo
            // 
            this.txtDividendo.Location = new System.Drawing.Point(220, 50);
            this.txtDividendo.Name = "txtDividendo";
            this.txtDividendo.Size = new System.Drawing.Size(100, 20);
            this.txtDividendo.TabIndex = 0;
            this.txtDividendo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtDivisor
            // 
            this.txtDivisor.Location = new System.Drawing.Point(220, 90);
            this.txtDivisor.Name = "txtDivisor";
            this.txtDivisor.Size = new System.Drawing.Size(100, 20);
            this.txtDivisor.TabIndex = 1;
            this.txtDivisor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtCociente
            // 
            this.txtCociente.Location = new System.Drawing.Point(220, 130);
            this.txtCociente.Name = "txtCociente";
            this.txtCociente.ReadOnly = true;
            this.txtCociente.Size = new System.Drawing.Size(100, 20);
            this.txtCociente.TabIndex = 2;
            this.txtCociente.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtResto
            // 
            this.txtResto.Location = new System.Drawing.Point(220, 170);
            this.txtResto.Name = "txtResto";
            this.txtResto.ReadOnly = true;
            this.txtResto.Size = new System.Drawing.Size(100, 20);
            this.txtResto.TabIndex = 3;
            this.txtResto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblDividendo
            // 
            this.lblDividendo.AutoSize = true;
            this.lblDividendo.Location = new System.Drawing.Point(50, 50);
            this.lblDividendo.Name = "lblDividendo";
            this.lblDividendo.Size = new System.Drawing.Size(57, 13);
            this.lblDividendo.TabIndex = 4;
            this.lblDividendo.Text = "Dividendo:";
            // 
            // lblDivisor
            // 
            this.lblDivisor.AutoSize = true;
            this.lblDivisor.Location = new System.Drawing.Point(50, 90);
            this.lblDivisor.Name = "lblDivisor";
            this.lblDivisor.Size = new System.Drawing.Size(42, 13);
            this.lblDivisor.TabIndex = 5;
            this.lblDivisor.Text = "Divisor:";
            // 
            // lblCociente
            // 
            this.lblCociente.AutoSize = true;
            this.lblCociente.Location = new System.Drawing.Point(50, 130);
            this.lblCociente.Name = "lblCociente";
            this.lblCociente.Size = new System.Drawing.Size(54, 13);
            this.lblCociente.TabIndex = 6;
            this.lblCociente.Text = "Cociente:";
            // 
            // lblResto
            // 
            this.lblResto.AutoSize = true;
            this.lblResto.Location = new System.Drawing.Point(50, 170);
            this.lblResto.Name = "lblResto";
            this.lblResto.Size = new System.Drawing.Size(37, 13);
            this.lblResto.TabIndex = 7;
            this.lblResto.Text = "Resto:";
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(150, 210);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(100, 30);
            this.btnCalcular.TabIndex = 8;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // _01
            // 
            this.ClientSize = new System.Drawing.Size(450, 300);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.lblResto);
            this.Controls.Add(this.lblCociente);
            this.Controls.Add(this.lblDivisor);
            this.Controls.Add(this.lblDividendo);
            this.Controls.Add(this.txtResto);
            this.Controls.Add(this.txtCociente);
            this.Controls.Add(this.txtDivisor);
            this.Controls.Add(this.txtDividendo);
            this.Name = "_01";
            this.Text = "Ejercicio 1 - Recursividad";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.TextBox txtDividendo;
        private System.Windows.Forms.TextBox txtDivisor;
        private System.Windows.Forms.TextBox txtCociente;
        private System.Windows.Forms.TextBox txtResto;
        private System.Windows.Forms.Label lblDividendo;
        private System.Windows.Forms.Label lblDivisor;
        private System.Windows.Forms.Label lblCociente;
        private System.Windows.Forms.Label lblResto;
        private System.Windows.Forms.Button btnCalcular;
    }
}
