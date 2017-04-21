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
    public partial class frmForm1 : Form
    {
        public string Nome { get; set; }

        public frmForm1(string _nome)
        {
            InitializeComponent();
            Nome = _nome;
            lblResultado.Text = Nome;
            
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.MessageBox.Show(Nome);
            this.Close();
        }
    }
}
