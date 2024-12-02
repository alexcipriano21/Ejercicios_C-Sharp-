namespace Ejercicios_C_.secuenciales
{
    public partial class _03 : Form
    {
        private System.ComponentModel.IContainer components = null;
        // Inicialización de componentes
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
            lblKilometros = new Label();
            lblPies = new Label();
            lblMillas = new Label();
            lblMetros = new Label();
            lblYardas = new Label();
            txtKilometros = new TextBox();
            txtPies = new TextBox();
            txtMillas = new TextBox();
            txtMetros = new TextBox();
            txtYardas = new TextBox();
            btnCalcular = new Button();
            SuspendLayout();
            // 
            // lblKilometros
            // 
            lblKilometros.AutoSize = true;
            lblKilometros.Location = new Point(50, 30);
            lblKilometros.Name = "lblKilometros";
            lblKilometros.Size = new Size(64, 15);
            lblKilometros.TabIndex = 0;
            lblKilometros.Text = "Kilómetros";
            // 
            // lblPies
            // 
            lblPies.AutoSize = true;
            lblPies.Location = new Point(50, 70);
            lblPies.Name = "lblPies";
            lblPies.Size = new Size(28, 15);
            lblPies.TabIndex = 1;
            lblPies.Text = "Pies";
            // 
            // lblMillas
            // 
            lblMillas.AutoSize = true;
            lblMillas.Location = new Point(50, 110);
            lblMillas.Name = "lblMillas";
            lblMillas.Size = new Size(38, 15);
            lblMillas.TabIndex = 2;
            lblMillas.Text = "Millas";
            // 
            // lblMetros
            // 
            lblMetros.AutoSize = true;
            lblMetros.Location = new Point(36, 193);
            lblMetros.Name = "lblMetros";
            lblMetros.Size = new Size(88, 15);
            lblMetros.TabIndex = 3;
            lblMetros.Text = "Total en Metros";
            // 
            // lblYardas
            // 
            lblYardas.AutoSize = true;
            lblYardas.Location = new Point(36, 233);
            lblYardas.Name = "lblYardas";
            lblYardas.Size = new Size(85, 15);
            lblYardas.TabIndex = 4;
            lblYardas.Text = "Total en Yardas";
            // 
            // txtKilometros
            // 
            txtKilometros.Location = new Point(149, 27);
            txtKilometros.Name = "txtKilometros";
            txtKilometros.Size = new Size(100, 23);
            txtKilometros.TabIndex = 5;
            // 
            // txtPies
            // 
            txtPies.Location = new Point(149, 70);
            txtPies.Name = "txtPies";
            txtPies.Size = new Size(100, 23);
            txtPies.TabIndex = 6;
            txtPies.TextChanged += txtPies_TextChanged;
            // 
            // txtMillas
            // 
            txtMillas.Location = new Point(149, 110);
            txtMillas.Name = "txtMillas";
            txtMillas.Size = new Size(100, 23);
            txtMillas.TabIndex = 7;
            // 
            // txtMetros
            // 
            txtMetros.Location = new Point(149, 190);
            txtMetros.Name = "txtMetros";
            txtMetros.ReadOnly = true;
            txtMetros.Size = new Size(100, 23);
            txtMetros.TabIndex = 8;
            // 
            // txtYardas
            // 
            txtYardas.Location = new Point(149, 230);
            txtYardas.Name = "txtYardas";
            txtYardas.ReadOnly = true;
            txtYardas.Size = new Size(100, 23);
            txtYardas.TabIndex = 9;
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(102, 281);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(75, 23);
            btnCalcular.TabIndex = 10;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // _03
            // 
            ClientSize = new Size(284, 341);
            Controls.Add(btnCalcular);
            Controls.Add(txtYardas);
            Controls.Add(txtMetros);
            Controls.Add(txtMillas);
            Controls.Add(txtPies);
            Controls.Add(txtKilometros);
            Controls.Add(lblYardas);
            Controls.Add(lblMetros);
            Controls.Add(lblMillas);
            Controls.Add(lblPies);
            Controls.Add(lblKilometros);
            Name = "_03";
            Text = "Conversor de Unidades";
            ResumeLayout(false);
            PerformLayout();
        }

        // Declaración de las variables private al final
        private Label lblKilometros;
        private Label lblPies;
        private Label lblMillas;
        private Label lblMetros;
        private Label lblYardas;
        private TextBox txtKilometros;
        private TextBox txtPies;
        private TextBox txtMillas;
        private TextBox txtMetros;
        private TextBox txtYardas;
        private Button btnCalcular;
    }
}
