using System;
using System.Windows.Forms;

namespace Classes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnExecutar_Click(object sender, EventArgs e)
        {
            Pessoa pessoa = new Pessoa();

            pessoa.nome = "Lucas";
            pessoa.sobrenome = "Gomes";

            pessoa.NomeCompleto();
        }
    }
}
