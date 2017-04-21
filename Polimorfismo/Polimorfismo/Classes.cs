using System;

namespace Polimorfismo
{
    #region Forma
    public abstract class FormaGeometrica
    {
        public int Largura { get; set; }
        public int Altura { get; set; }

        public void Apresentar()
        {
            Console.WriteLine("Este é um método da classe base");
        }

        public abstract void Desenhar();

        public virtual void DesenharOutro()
        {
            Console.WriteLine("Método virtual da classe base");
        }
    }
    #endregion

    #region Retangulo
    public class Retangulo : FormaGeometrica
    {
        public override void Desenhar()
        {
            Console.WriteLine($"Retangulo com {Largura} de largura por {Altura} de altura");
        }

        public override void DesenharOutro()
        {
            Console.WriteLine("Este é um metodo virtual sobrescrito na classe derivada");  
        }
    }
    #endregion

    #region Triangulo
    public class Triangulo : FormaGeometrica
    {
        public override void Desenhar()
        {
            Console.WriteLine($"Triangulo com {Largura} de largura por {Altura} de altura");
        }
    }
    #endregion

    #region Circulo
    public class Circulo : FormaGeometrica
    {
        public override void Desenhar()
        {
            Console.WriteLine($"Circulo com {Largura} de largura por {Altura} de altura");
        }
    }
    #endregion
}