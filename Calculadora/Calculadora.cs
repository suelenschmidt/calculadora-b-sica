namespace Calculadora
{
    public class Calculadora
    {
        public int Soma(int a, int b)
        {
            return a + b;
        }

        public int Subtracao(int a, int b)
        {
            return a - b;
        }

        public int Multiplicacao(int a, int b)
        {
            return a * b;
        }

        public int Divisao(int a, int b)
        {
            if (b == 0)
            {
                throw new ArgumentException("Divisão por zero não é permitida.");
            }
            return a / b;
        }
    }
}
