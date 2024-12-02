namespace Ejercicios_C_.secuenciales
{
    partial class _01
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
            lblVarones = new Label();
            lblMujeres = new Label();
            lblPVarones = new Label();
            lblPMujeres = new Label();
            txtVarones = new TextBox();
            txtMujeres = new TextBox();
            btnCalcular = new Button();
            SuspendLayout();
            // 
            // lblVarones
            // 
            lblVarones.AccessibleName = "lblvarones";
            lblVarones.AutoSize = true;
            lblVarones.Location = new Point(50, 50);
            lblVarones.Name = "lblVarones";
            lblVarones.Size = new Size(48, 15);
            lblVarones.TabIndex = 0;
            lblVarones.Text = "Varones";
            lblVarones.Click += label1_Click;
            // 
            // lblMujeres
            // 
            lblMujeres.AccessibleName = "lblmujeres";
            lblMujeres.AutoSize = true;
            lblMujeres.Location = new Point(50, 112);
            lblMujeres.Name = "lblMujeres";
            lblMujeres.Size = new Size(49, 15);
            lblMujeres.TabIndex = 0;
            lblMujeres.Text = "Mujeres";
            lblMujeres.Click += label2_Click;
            // 
            // lblPVarones
            // 
            lblPVarones.AccessibleName = "Pvarones";
            lblPVarones.AutoSize = true;
            lblPVarones.Location = new Point(223, 50);
            lblPVarones.Name = "lblPVarones";
            lblPVarones.Size = new Size(17, 15);
            lblPVarones.TabIndex = 0;
            lblPVarones.Text = "%";
            // 
            // lblPMujeres
            // 
            lblPMujeres.AccessibleName = "Pmujeres";
            lblPMujeres.AutoSize = true;
            lblPMujeres.Location = new Point(223, 112);
            lblPMujeres.Name = "lblPMujeres";
            lblPMujeres.Size = new Size(17, 15);
            lblPMujeres.TabIndex = 0;
            lblPMujeres.Text = "%";
            // 
            // txtVarones
            // 
            txtVarones.AccessibleName = "txtVarones";
            txtVarones.AccessibleRole = AccessibleRole.None;
            txtVarones.Location = new Point(117, 47);
            txtVarones.Name = "txtVarones";
            txtVarones.Size = new Size(100, 23);
            txtVarones.TabIndex = 1;
            txtVarones.TextChanged += textBox1_TextChanged;
            // 
            // txtMujeres
            // 
            txtMujeres.AccessibleName = "txtMujeres";
            txtMujeres.Location = new Point(117, 104);
            txtMujeres.Name = "txtMujeres";
            txtMujeres.Size = new Size(100, 23);
            txtMujeres.TabIndex = 1;
            txtMujeres.TextChanged += textBox2_TextChanged;
            // 
            // btnCalcular
            // 
            btnCalcular.AccessibleName = "btnCalcular";
            btnCalcular.Location = new Point(113, 154);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(75, 23);
            btnCalcular.TabIndex = 2;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += button1_Click;
            // 
            // _01
            // 
            AccessibleName = "_01";
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(284, 211);
            Controls.Add(btnCalcular);
            Controls.Add(txtMujeres);
            Controls.Add(txtVarones);
            Controls.Add(lblPMujeres);
            Controls.Add(lblMujeres);
            Controls.Add(lblPVarones);
            Controls.Add(lblVarones);
            Name = "_01";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "_01";
            Load += _01_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblVarones;
        private Label lblMujeres;
        private Label lblPVarones;
        private Label lblPMujeres;
        private TextBox txtVarones;
        private TextBox txtMujeres;
        private Button btnCalcular;
    }
}