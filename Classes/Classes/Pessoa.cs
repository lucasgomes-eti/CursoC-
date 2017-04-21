using System.Windows.Forms;

namespace Classes
{
    class Pessoa
    {
        public string nome;
        public string sobrenome;

        public void NomeCompleto()
        {
            MessageBox.Show(CriarNomeCompleto());
        }

        private string CriarNomeCompleto()
        {
            string _nomecompleto = ($"{nome} {sobrenome}");
            return _nomecompleto;
        }
    }
}
