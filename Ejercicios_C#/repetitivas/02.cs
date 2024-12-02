using System;
using System.Windows.Forms;

namespace Ejercicios_C_.repetitivas
{
    public partial class _02 : Form
    {
        public _02()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            btnCalcular_actionPerformed();
        }

        private void btnCalcular_actionPerformed()
        {
            int numero1 = int.Parse(txtNumero1.Text);
            int numero2 = int.Parse(txtNumero2.Text);
            int resultado = 0;

            for (int i = 0; i < Math.Abs(numero2); i++)
            {
                resultado += numero1;
            }

            if (numero2 < 0)
            {
                resultado = -resultado;
            }

            txtResultado.Text = resultado.ToString();
        }
    }
}
