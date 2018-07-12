using System;

namespace StrategyBasico
{
    class Program
    {
        static void Main(string[] args)
        {
            var contexto = new CalculadoraContext(new Suma());

            var resultado = contexto.EjecutarCalculo(2, 3);

            Console.WriteLine($"el resultado es: { resultado }");

            Console.ReadLine();
        }
    }

    public class CalculadoraContext
    {
        ICalculoStrategy _calculoStrategy;

        public CalculadoraContext(ICalculoStrategy calculoStrategy)
        {
            _calculoStrategy = calculoStrategy;
        }

        public int EjecutarCalculo(int numero1, int numero2)
        {
            return _calculoStrategy.Calcular(numero1, numero2);
        }
    }

    public interface ICalculoStrategy
    {
        int Calcular(int numero1, int numero2);
    }

    public class Suma : ICalculoStrategy
    {
        public int Calcular(int numero1, int numero2)
        {
            return numero1 + numero2;
        }
    }

    public class Resta : ICalculoStrategy
    {
        public int Calcular(int numero1, int numero2)
        {
            return numero1 - numero2;
        }
    }
}
