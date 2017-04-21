using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasseEstaticas
{
    public static class estatica
    {
        public static string Nome { get; set; }

        public static void Apresentar()
        {
            Console.WriteLine(Nome);
        }
    }
}
