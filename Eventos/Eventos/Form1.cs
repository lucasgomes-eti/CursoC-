using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Eventos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lblResultado_MouseEnter(object sender, EventArgs e)
        {
            lblResultado.BackColor = Color.White;
        }

        private void lblResultado_MouseLeave(object sender, EventArgs e)
        {
            lblResultado.BackColor = Color.Transparent;
        }

        private void lblResultado_MouseDown(object sender, MouseEventArgs e)
        {
            lblResultado.BackColor = Color.YellowGreen;
        }

        private void lblResultado_MouseUp(object sender, MouseEventArgs e)
        {
            lblResultado.BackColor = Color.Transparent;
        }

        private void txtTexto_TextChanged(object sender, EventArgs e)
        {
            lblResultado.Text = txtTexto.Text;
        }
    }
}
