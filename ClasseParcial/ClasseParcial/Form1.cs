using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClasseParcial
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Pessoa p1 = new Pessoa();

            p1.Nome = "Lucas";
            p1.Sobrenome = "Gomes";
            p1.Idade = 20;

            p1.Apresentar();
        }
    }
}
