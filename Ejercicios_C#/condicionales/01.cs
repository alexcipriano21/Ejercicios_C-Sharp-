using System;
using System.Globalization;
using System.Windows.Forms;

namespace Ejercicios_C_.condicionales
{
    public partial class _01 : Form
    {
        public _01()
        {
            InitializeComponent();
        }

        private void BtnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                int unidades = int.Parse(txtUnidades.Text);
                double precioUnitario = (unidades >= 1 && unidades <= 25) ? 27 :
                                         (unidades >= 26 && unidades <= 50) ? 25 : 23;

                double importeCompra = unidades * precioUnitario;
                double descuento = (unidades > 50) ? (importeCompra * 0.15) : (importeCompra * 0.05);
                double totalPagar = importeCompra - descuento;

                txtImporteCompra.Text = importeCompra.ToString("F2", CultureInfo.InvariantCulture);
                txtDescuento.Text = descuento.ToString("F2", CultureInfo.InvariantCulture);
                txtTotalPagar.Text = totalPagar.ToString("F2", CultureInfo.InvariantCulture);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Por favor, ingrese un valor válido. \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
