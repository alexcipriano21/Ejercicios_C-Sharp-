namespace Ejercicios_C_.secuenciales
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
            lblMetros = new Label();
            lblCentimetros = new Label();
            lblPulgadas = new Label();
            lblPies = new Label();
            lblYardas = new Label();
            txtMetros = new TextBox();
            txtCentimetros = new TextBox();
            txtPulgadas = new TextBox();
            txtPies = new TextBox();
            txtYardas = new TextBox();
            btnCalcular = new Button();
            SuspendLayout();
            // 
            // lblMetros
            // 
            lblMetros.AutoSize = true;
            lblMetros.Location = new Point(50, 30);
            lblMetros.Name = "lblMetros";
            lblMetros.Size = new Size(44, 15);
            lblMetros.TabIndex = 0;
            lblMetros.Text = "Metros";
            // 
            // lblCentimetros
            // 
            lblCentimetros.AutoSize = true;
            lblCentimetros.Location = new Point(50, 70);
            lblCentimetros.Name = "lblCentimetros";
            lblCentimetros.Size = new Size(72, 15);
            lblCentimetros.TabIndex = 0;
            lblCentimetros.Text = "Centímetros";
            // 
            // lblPulgadas
            // 
            lblPulgadas.AutoSize = true;
            lblPulgadas.Location = new Point(50, 110);
            lblPulgadas.Name = "lblPulgadas";
            lblPulgadas.Size = new Size(55, 15);
            lblPulgadas.TabIndex = 0;
            lblPulgadas.Text = "Pulgadas";
            // 
            // lblPies
            // 
            lblPies.AutoSize = true;
            lblPies.Location = new Point(50, 150);
            lblPies.Name = "lblPies";
            lblPies.Size = new Size(28, 15);
            lblPies.TabIndex = 0;
            lblPies.Text = "Pies";
            // 
            // lblYardas
            // 
            lblYardas.AutoSize = true;
            lblYardas.Location = new Point(50, 190);
            lblYardas.Name = "lblYardas";
            lblYardas.Size = new Size(41, 15);
            lblYardas.TabIndex = 0;
            lblYardas.Text = "Yardas";
            // 
            // txtMetros
            // 
            txtMetros.Location = new Point(150, 27);
            txtMetros.Name = "txtMetros";
            txtMetros.Size = new Size(100, 23);
            txtMetros.TabIndex = 1;
            // 
            // txtCentimetros
            // 
            txtCentimetros.Location = new Point(150, 67);
            txtCentimetros.Name = "txtCentimetros";
            txtCentimetros.ReadOnly = true;
            txtCentimetros.Size = new Size(100, 23);
            txtCentimetros.TabIndex = 1;
            // 
            // txtPulgadas
            // 
            txtPulgadas.Location = new Point(150, 107);
            txtPulgadas.Name = "txtPulgadas";
            txtPulgadas.ReadOnly = true;
            txtPulgadas.Size = new Size(100, 23);
            txtPulgadas.TabIndex = 1;
            // 
            // txtPies
            // 
            txtPies.Location = new Point(150, 147);
            txtPies.Name = "txtPies";
            txtPies.ReadOnly = true;
            txtPies.Size = new Size(100, 23);
            txtPies.TabIndex = 1;
            // 
            // txtYardas
            // 
            txtYardas.Location = new Point(150, 187);
            txtYardas.Name = "txtYardas";
            txtYardas.ReadOnly = true;
            txtYardas.Size = new Size(100, 23);
            txtYardas.TabIndex = 1;
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(110, 240);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(75, 23);
            btnCalcular.TabIndex = 2;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // _02
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(300, 300);
            Controls.Add(lblMetros);
            Controls.Add(lblCentimetros);
            Controls.Add(lblPulgadas);
            Controls.Add(lblPies);
            Controls.Add(lblYardas);
            Controls.Add(txtMetros);
            Controls.Add(txtCentimetros);
            Controls.Add(txtPulgadas);
            Controls.Add(txtPies);
            Controls.Add(txtYardas);
            Controls.Add(btnCalcular);
            Name = "_02";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Conversión de Unidades";
            Load += _02_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblMetros;
        private Label lblCentimetros;
        private Label lblPulgadas;
        private Label lblPies;
        private Label lblYardas;
        private TextBox txtMetros;
        private TextBox txtCentimetros;
        private TextBox txtPulgadas;
        private TextBox txtPies;
        private TextBox txtYardas;
        private Button btnCalcular;
    }
}
