using System;
using System.Windows.Forms;

namespace Ejercicios_C_.recursividad
{
    public partial class _03 : Form
    {
        public _03()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int numero = int.Parse(txtNumero.Text);
            int cantidadDivisores = ContarDivisores(numero, 1, 0);
            txtCantidadDivisores.Text = cantidadDivisores.ToString();
        }

        private int ContarDivisores(int numero, int i, int contador)
        {
            if (i > numero)
            {
                return contador;
            }

            if (numero % i == 0)
            {
                contador++;
            }

            return ContarDivisores(numero, i + 1, contador);
        }
    }
}
