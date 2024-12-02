using System;
using System.Windows.Forms;

namespace Ejercicios_C_.recursividad
{
    public partial class _01 : Form
    {
        public _01()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            btnCalcular_actionPerformed();
        }

        private void btnCalcular_actionPerformed()
        {
            int dividendo = int.Parse(txtDividendo.Text);
            int divisor = int.Parse(txtDivisor.Text);

            if (divisor == 0)
            {
                txtCociente.Text = "División por 0";
                txtResto.Text = "";
                return;
            }

            Respuesta resultado = calcularCocienteYRestos(dividendo, divisor, 0);

            txtCociente.Text = resultado.Cociente.ToString();
            txtResto.Text = resultado.Resto.ToString();
        }

        private Respuesta calcularCocienteYRestos(int dividendo, int divisor, int cociente)
        {
            if (dividendo < divisor)
            {
                return new Respuesta(cociente, dividendo);
            }
            else
            {
                return calcularCocienteYRestos(dividendo - divisor, divisor, cociente + 1);
            }
        }

        private class Respuesta
        {
            public int Cociente { get; set; }
            public int Resto { get; set; }

            public Respuesta(int cociente, int resto)
            {
                Cociente = cociente;
                Resto = resto;
            }
        }
    }
}
