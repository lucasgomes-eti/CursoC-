using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formularios
{
    public partial class frmHome : Form
    {
        public frmHome()
        {
            InitializeComponent();
        }

        private void btnForm1_Click(object sender, EventArgs e)
        {
            frmForm1 form1 = new frmForm1(txtNome.Text);
            form1.ShowDialog();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnForm2_Click(object sender, EventArgs e)
        {
            frmForm2 form2 = new frmForm2();
            form2.Show();
            this.Hide();
        }
    }
}
