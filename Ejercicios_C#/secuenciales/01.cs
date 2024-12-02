namespace Ejercicios_C_.secuenciales
{
    public partial class _01 : Form
    {
        public _01()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int varones = int.Parse(txtVarones.Text);
            int mujeres = int.Parse(txtMujeres.Text);

            int total = varones + mujeres;
            double pVarones = varones * 100.0 / total;
            double pMujeres = mujeres * 100.0 / total;

            lblPVarones.Text = string.Format("{0:0.00} %", pVarones);
            lblPMujeres.Text = string.Format("{0:0.00} %", pMujeres);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void _01_Load(object sender, EventArgs e)
        {

        }
    }
}