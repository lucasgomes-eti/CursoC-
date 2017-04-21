using System;
using System.Windows.Forms;

namespace Encapsulamento
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnExecutar_Click(object sender, EventArgs e)
        {
            int tipoProduto = 0;

            if (rdAlimento.Checked)
            {
                tipoProduto = 1;
            }
            else if (rdRoupa.Checked)
            {
                tipoProduto = 2;
            }
            else if (rdHigiene.Checked)
            {
                tipoProduto = 3;
            }

            Calculo obj = new Calculo();
            

            lblResultado.Text = obj.CalcularValor(Convert.ToInt16(lblValor.Text), tipoProduto).ToString();
        }
    }
}
