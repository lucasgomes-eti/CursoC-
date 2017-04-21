using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasseParcial
{
    partial class Pessoa
    {
        public void Apresentar()
        {
            Console.WriteLine($"{Nome} {Sobrenome} {Idade} anos");
        }
    }
}
