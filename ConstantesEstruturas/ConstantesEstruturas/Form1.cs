using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConstantesEstruturas
{
    public partial class Form1 : Form
    {
        struct pessoa
        {
            public string Nome { get; set; }
            public int Idade { get; set; }
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pessoa p1 = new pessoa();

            Console.WriteLine(estatica.Nome);
            Console.WriteLine($"{p1.Nome=estatica.Nome} {p1.Idade=20} anos");
        }
    }
}
