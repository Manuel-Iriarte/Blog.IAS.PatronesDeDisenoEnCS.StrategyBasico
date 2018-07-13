namespace StrategyBasico
{
    public class Suma : ICalculoStrategy
    {
        public int Calcular(int numero1, int numero2)
        {
            return numero1 + numero2;
        }
    }
}
