﻿namespace StrategyBasico
{
    public class Resta : ICalculoStrategy
    {
        public int Calcular(int numero1, int numero2)
        {
            return numero1 - numero2;
        }
    }
}
