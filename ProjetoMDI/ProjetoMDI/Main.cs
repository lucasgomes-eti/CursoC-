using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoMDI
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void fromulário1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 objForm1 = new Form1(this);
            objForm1.Show();
        }
    }
}
