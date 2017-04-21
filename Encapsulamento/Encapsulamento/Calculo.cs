using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulamento
{
    public class Calculo
    {
        private int pct1 = 7;
        private int pct2 = 13;
        private int pct3 = 27;

        public int CalcularValor(int valorInicial, int tipoProduto)
        {
            int valorFinal = 0;
            switch (tipoProduto)
            {
                case 1:
                    valorFinal = (valorInicial + pct1) / 100;
                    break;

                case 2:
                    valorFinal = (valorInicial + pct2) / 100;
                    break;

                case 3:
                    valorFinal = (valorInicial + pct3) / 100;
                    break;

                default:
                    break;
            }
            return valorFinal;
        }
    }
}
