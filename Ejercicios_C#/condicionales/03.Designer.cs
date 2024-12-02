using System;
using System.Windows.Forms;

namespace Ejercicios_C_.condicionales
{
    public partial class _03 : Form
    {
        public _03()
        {
            InitializeComponent();
        }

        private void btnClasificar_Click(object sender, EventArgs e)
        {
            double angulo;
            if (double.TryParse(txtAngulo.Text, out angulo))
            {
                string clasificacion;

                if (angulo == 0)
                {
                    clasificacion = "Nulo";
                }
                else if (angulo > 0 && angulo < 90)
                {
                    clasificacion = "Agudo";
                }
                else if (angulo == 90)
                {
                    clasificacion = "Recto";
                }
                else if (angulo > 90 && angulo < 180)
                {
                    clasificacion = "Obtuso";
                }
                else if (angulo == 180)
                {
                    clasificacion = "Llano";
                }
                else if (angulo > 180 && angulo < 360)
                {
                    clasificacion = "Cóncavo";
                }
                else if (angulo == 360)
                {
                    clasificacion = "Completo";
                }
                else
                {
                    clasificacion = "Ángulo inválido";
                }

                txtClasificacion.Text = clasificacion;
            }
            else
            {
                MessageBox.Show("Por favor ingrese un valor válido para el ángulo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
