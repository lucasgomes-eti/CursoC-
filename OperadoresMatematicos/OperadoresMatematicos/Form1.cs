using System;
using System.Windows.Forms;

namespace OperadoresMatematicos
{
    public partial class Form1 : Form
    {
        int resultado;

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnExecutar_Click(object sender, EventArgs e)
        {
                         
        }

        private void btnSoma_Click(object sender, EventArgs e)
        {
            int valor1 = int.Parse(txtValor1.Text);
            int valor2 = int.Parse(txtValor2.Text);

            resultado = valor1 + valor2;

            lblResultado.Text = resultado.ToString();
        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            int valor1 = int.Parse(txtValor1.Text);
            int valor2 = int.Parse(txtValor2.Text);

            resultado = valor1 - valor2;

            lblResultado.Text = resultado.ToString();
        }

        private void btnMulti_Click(object sender, EventArgs e)
        {
            int valor1 = int.Parse(txtValor1.Text);
            int valor2 = int.Parse(txtValor2.Text);

            resultado = valor1 * valor2;

            lblResultado.Text = resultado.ToString();
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            int valor1 = int.Parse(txtValor1.Text);
            int valor2 = int.Parse(txtValor2.Text);

            resultado = valor1 / valor2;

            lblResultado.Text = resultado.ToString();
        }

        private void btnResto_Click(object sender, EventArgs e)
        {
            int valor1 = int.Parse(txtValor1.Text);
            int valor2 = int.Parse(txtValor2.Text);

            //Resto da divisão
            resultado = valor1 % valor2;

            lblResultado.Text = resultado.ToString();
        }
    }
}
