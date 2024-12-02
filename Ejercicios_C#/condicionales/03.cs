namespace Ejercicios_C_.condicionales
{
    partial class _03
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar cualquier recurso que esté siendo utilizado.
        /// </summary>
        /// <param name="disposing">Si se deben liberar los recursos administrados.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador de Windows Forms.
        /// No se puede modificar el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblAngulo = new System.Windows.Forms.Label();
            this.txtAngulo = new System.Windows.Forms.TextBox();
            this.lblClasificacion = new System.Windows.Forms.Label();
            this.txtClasificacion = new System.Windows.Forms.TextBox();
            this.btnClasificar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblAngulo
            // 
            this.lblAngulo.AutoSize = true;
            this.lblAngulo.Location = new System.Drawing.Point(50, 30);
            this.lblAngulo.Name = "lblAngulo";
            this.lblAngulo.Size = new System.Drawing.Size(54, 15);
            this.lblAngulo.TabIndex = 0;
            this.lblAngulo.Text = "Ángulo:";
            // 
            // txtAngulo
            // 
            this.txtAngulo.Location = new System.Drawing.Point(150, 30);
            this.txtAngulo.Name = "txtAngulo";
            this.txtAngulo.Size = new System.Drawing.Size(100, 23);
            this.txtAngulo.TabIndex = 1;
            this.txtAngulo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblClasificacion
            // 
            this.lblClasificacion.AutoSize = true;
            this.lblClasificacion.Location = new System.Drawing.Point(50, 70);
            this.lblClasificacion.Name = "lblClasificacion";
            this.lblClasificacion.Size = new System.Drawing.Size(79, 15);
            this.lblClasificacion.TabIndex = 2;
            this.lblClasificacion.Text = "Clasificación:";
            // 
            // txtClasificacion
            // 
            this.txtClasificacion.Location = new System.Drawing.Point(150, 70);
            this.txtClasificacion.Name = "txtClasificacion";
            this.txtClasificacion.ReadOnly = true;
            this.txtClasificacion.Size = new System.Drawing.Size(100, 23);
            this.txtClasificacion.TabIndex = 3;
            this.txtClasificacion.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnClasificar
            // 
            this.btnClasificar.Location = new System.Drawing.Point(100, 120);
            this.btnClasificar.Name = "btnClasificar";
            this.btnClasificar.Size = new System.Drawing.Size(100, 30);
            this.btnClasificar.TabIndex = 4;
            this.btnClasificar.Text = "Clasificar";
            this.btnClasificar.UseVisualStyleBackColor = true;
            this.btnClasificar.Click += new System.EventHandler(this.btnClasificar_Click);
            // 
            // _03
            // 
            this.ClientSize = new System.Drawing.Size(320, 200);
            this.Controls.Add(this.btnClasificar);
            this.Controls.Add(this.txtClasificacion);
            this.Controls.Add(this.lblClasificacion);
            this.Controls.Add(this.txtAngulo);
            this.Controls.Add(this.lblAngulo);
            this.Name = "_03";
            this.Text = "Clasificación de Ángulo";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblAngulo;
        private System.Windows.Forms.TextBox txtAngulo;
        private System.Windows.Forms.Label lblClasificacion;
        private System.Windows.Forms.TextBox txtClasificacion;
        private System.Windows.Forms.Button btnClasificar;
    }
}
