using StrategyBasico2.CalculadoraEngine;
using System;

namespace StrategyBasico2
{
    class Program
    {
        static void Main(string[] args)
        {
            // este valor es ingresado o obtenido de alguna forma
            TipoCalculo tipoCalculo = TipoCalculo.Resta;

            // suponiendo estos numeros los ingresa el usuario
            int numero1 = 2;
            int numero2 = 5;

            var contexto = new CalculadoraContext(tipoCalculo);

            var resultado = contexto.EjecutarCalculo(numero1, numero2);

            Console.WriteLine($"el resultado es: { resultado }");

            Console.ReadLine();
        }
    }
}
