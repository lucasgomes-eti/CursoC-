using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Strings
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnExecutar_Click(object sender, EventArgs e)
        {
            string nome = "Lucas Gomes";

            lblResultado.Text = nome.Substring(0, 5);

            bool verificar = nome.Contains("Lucas");

            lblResultado.Text = $"{lblResultado.Text} {verificar.ToString()}";
        }
    }
}
