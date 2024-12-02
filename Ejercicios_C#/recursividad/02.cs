using System;
using System.Windows.Forms;

namespace Ejercicios_C_.recursividad
{
    public partial class _02 : Form
    {
        public _02()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int numero1 = int.Parse(txtNumero1.Text);
            int numero2 = int.Parse(txtNumero2.Text);

            int resultado = Multiplicar(numero1, Math.Abs(numero2));

            if (numero2 < 0)
            {
                resultado = -resultado;
            }

            txtResultado.Text = resultado.ToString();
        }

        private int Multiplicar(int numero1, int numero2)
        {
            if (numero2 == 0)
            {
                return 0;
            }
            return numero1 + Multiplicar(numero1, numero2 - 1);
        }
    }
}
