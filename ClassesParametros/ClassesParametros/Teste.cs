using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesParametros
{
    class Teste
    {
        public void Executar(ref int valor)
        {
            ++valor;
        }

        public int Executar2(int valor)
        {
            ++valor;
            return valor;
        }
    }
}
