using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Enumeracoes
{
    public partial class Form1 : Form
    {
        teste jogador;

        public Form1()
        {
            InitializeComponent();
            jogador = new teste();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void btnEsquerda_Click(object sender, EventArgs e)
        {
            jogador.ApresentarDia(teste.Movimentos.Esquerda);
        }

        private void btnCima_Click(object sender, EventArgs e)
        {
            jogador.ApresentarDia(teste.Movimentos.Cima);
        }

        private void btnBaixo_Click(object sender, EventArgs e)
        {
            jogador.ApresentarDia(teste.Movimentos.Baixo);
        }

        private void btnDireita_Click(object sender, EventArgs e)
        {
            jogador.ApresentarDia(teste.Movimentos.Direita);
        }
    }
}
