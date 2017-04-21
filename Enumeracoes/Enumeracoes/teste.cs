using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enumeracoes
{
    class teste
    {
        public enum Movimentos
        {
            Esquerda, Cima, Direita, Baixo
        }

        public void ApresentarDia(Movimentos movimento)
        {
            System.Windows.Forms.MessageBox.Show($"O Jogador se moveu para {movimento}");
        }
    }
}
