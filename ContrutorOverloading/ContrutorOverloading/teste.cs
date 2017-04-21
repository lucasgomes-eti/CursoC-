using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContrutorOverloading
{
    class teste
    {
        string nome;
        int idade;

        public teste(string nome, int idade)
        {
            this.nome = nome;
            this.idade = idade;
        }
        
        //Overloading

        public void Apresentar()
        {
            System.Windows.Forms.MessageBox.Show($"{nome}, {idade} anos");
        }

        public void Apresentar(string separador)
        {
            System.Windows.Forms.MessageBox.Show($"{nome} {separador} {idade} anos");
        }

    }
}
