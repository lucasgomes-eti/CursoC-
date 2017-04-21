using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heranca
{
    public class Carro : Veiculo
    {
        public int MedidorVelocidade { get; set; }

        public void OlharMedidor()
        {
            System.Windows.Forms.MessageBox.Show(Velocidade.ToString());
        }

        public override void Parar()
        {
            Console.WriteLine("O carro parou");
        }
    }
}
