using System;
using System.Windows.Forms;

namespace Ejercicios_C_.repetitivas
{
    public partial class _01 : Form
    {
        public _01()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int dividendo = Convert.ToInt32(txtDividendo.Text);
            int divisor = Convert.ToInt32(txtDivisor.Text);
            int cociente = 0;
            int resto = dividendo;

            if (divisor == 0)
            {
                txtCociente.Text = "División por 0";
                txtResto.Text = "";
                return;
            }

            while (resto >= divisor)
            {
                resto -= divisor;
                cociente++;
            }

            txtCociente.Text = cociente.ToString();
            txtResto.Text = resto.ToString();
        }
    }
}
