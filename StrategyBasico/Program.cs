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
}
