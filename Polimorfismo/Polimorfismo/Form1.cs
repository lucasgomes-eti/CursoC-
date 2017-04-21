using System;
using System.Windows.Forms;

namespace Polimorfismo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnExecutar_Click(object sender, EventArgs e)
        {
            Retangulo objRetangulo = new Retangulo();
            Triangulo objTriangulo = new Triangulo();
            Circulo objCirculo = new Circulo();

            objRetangulo.Largura = 50;
            objRetangulo.Altura = 50;
            objRetangulo.Apresentar();
            objRetangulo.Desenhar();
            objRetangulo.DesenharOutro();


            objTriangulo.Largura = 40;
            objTriangulo.Altura = 80;
            objTriangulo.Apresentar();
            objTriangulo.Desenhar();
            objTriangulo.DesenharOutro();

            objCirculo.Largura = 152;
            objCirculo.Altura = 152;
            objCirculo.Apresentar();
            objCirculo.Desenhar();
            objCirculo.DesenharOutro();
        }
    }
}
