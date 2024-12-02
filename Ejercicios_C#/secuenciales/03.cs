using System;
using System.Windows.Forms;

namespace Ejercicios_C_.secuenciales
{
    public partial class _03 : Form
    {
        public _03()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                // Leer los valores ingresados en los cuadros de texto
                double kilometros = double.Parse(txtKilometros.Text);
                double pies = double.Parse(txtPies.Text);
                double millas = double.Parse(txtMillas.Text);

                // Realizar las conversiones
                double totalMetros = (kilometros * 1000) + (pies / 3.2808) + (millas * 1609);
                double totalYardas = totalMetros * 1.09361;

                // Mostrar los resultados en los cuadros de texto
                txtMetros.Text = totalMetros.ToString("F2");
                txtYardas.Text = totalYardas.ToString("F2");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en los datos de entrada: " + ex.Message);
            }
        }

        private void txtPies_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
