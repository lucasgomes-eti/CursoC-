using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heranca
{
    abstract public class Veiculo
    {
        public ConsoleColor Cor { get; set; }
        public string Marca { get; set; }
        public int Velocidade { get; set; }

        public void Acelerar()
        {
            for (int i = 0; i < 40; i++)
            {
                Velocidade++;
            }
        }
        public virtual void Parar()
        {
            Console.WriteLine("Parou");
        }
    }
}
