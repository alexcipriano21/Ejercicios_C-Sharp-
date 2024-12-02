namespace Ejercicios_C_.secuenciales
{
    public partial class _02 : Form
    {
        public _02()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                int metros = int.Parse(txtMetros.Text);

                double centimetros = metros * 100;
                double pulgadas = centimetros / 2.54;
                double pies = pulgadas / 12;
                double yardas = pies / 3;

                txtCentimetros.Text = string.Format("{0:0.00}", centimetros);
                txtPulgadas.Text = string.Format("{0:0.00}", pulgadas);
                txtPies.Text = string.Format("{0:0.00}", pies);
                txtYardas.Text = string.Format("{0:0.00}", yardas);
            }
            catch (Exception)
            {
                MessageBox.Show("Por favor, introduce un número válido en metros.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void _02_Load(object sender, EventArgs e)
        {

        }
    }
}
