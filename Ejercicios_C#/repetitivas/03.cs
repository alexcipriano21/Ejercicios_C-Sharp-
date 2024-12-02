using System;
using System.Windows.Forms;

namespace Ejercicios_C_.repetitivas
{
    public partial class _03 : Form
    {
        public _03()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            btnCalcular_actionPerformed();
        }

        private void btnCalcular_actionPerformed()
        {
            int numero = int.Parse(txtNumero.Text);
            int contador = 0;

            for (int i = 1; i <= numero; i++)
            {
                if (numero % i == 0)
                {
                    contador++;
                }
            }

            txtCantidadDivisores.Text = contador.ToString();
        }
    }
}
