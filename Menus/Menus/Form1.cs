using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Menus
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void propertiesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
        }

        private void btnExecutar_Click(object sender, EventArgs e)
        {
            for (int i = 1; i <= 10; i++)
            {
                cmbOptions.Items.Add(i);
            }
        }

        private void cmbOptions_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblResultado.Text = cmbOptions.Text;

            switch (cmbOptions.Text)
            {
                case "1":
                    {
                        MessageBox.Show("1");
                        break;
                    }
                default:
                    break;
            }
        }
    }
}
