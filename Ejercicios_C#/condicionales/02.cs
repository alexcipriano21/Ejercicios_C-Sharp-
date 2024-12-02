using System;
using System.Windows.Forms;

namespace Ejercicios_C_.condicionales
{
    public partial class _02 : Form
    {
        public _02()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int unidades = int.Parse(txtUnidades.Text);
            double precioUnitario = 20.0;
            double importeCompra = unidades * precioUnitario;
            double descuento;
            double totalPagar;
            int caramelos;

            if (importeCompra > 700)
            {
                descuento = importeCompra * 0.16;
            }
            else if (importeCompra >= 501)
            {
                descuento = importeCompra * 0.14;
            }
            else
            {
                descuento = importeCompra * 0.12;
            }

            totalPagar = importeCompra - descuento;

            if (unidades >= 1 && unidades <= 50)
            {
                caramelos = 5;
            }
            else if (unidades >= 51 && unidades <= 100)
            {
                caramelos = 10;
            }
            else
            {
                caramelos = 15;
            }

            txtImporte.Text = string.Format("{0:0.00}", importeCompra);
            txtDescuento.Text = string.Format("{0:0.00}", descuento);
            txtTotalPagar.Text = string.Format("{0:0.00}", totalPagar);
            txtCaramelos.Text = caramelos.ToString();
        }
    }
}
