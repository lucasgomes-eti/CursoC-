namespace ClassesMetodos
{
    class Matematica
    {
        public bool erro;
        public string resultadoAlt;
        public double resultado;
        double primeiroValor, segundoValor;
        public string Operacao(double primeiroValor, double segundoValor, string operador)
        {
            this.primeiroValor = primeiroValor;
            this.segundoValor = segundoValor;

            switch (operador)
            {
                case "soma":
                    resultado = Adicao();
                    break;
                case "subtracao":
                    resultado = Subtracao();
                    break;
                case "multiplicacao":
                    resultado = Multiplicacao();
                    break;
                case "divisao":
                    resultado = Divisao();
                    break;

                default:
                    erro = true;
                    break;
            }

            if (erro == true)
            {
                return resultadoAlt = "Erro";
            }
            else
            {
                return resultado.ToString();
            }

        }

        private double Adicao()
        {
            return primeiroValor + segundoValor;
        }
        private double Subtracao()
        {
            return primeiroValor - segundoValor;
        }
        private double Multiplicacao()
        {
            return primeiroValor * segundoValor;
        }
        private double Divisao()
        {
            return primeiroValor + segundoValor;
        }
    }
}