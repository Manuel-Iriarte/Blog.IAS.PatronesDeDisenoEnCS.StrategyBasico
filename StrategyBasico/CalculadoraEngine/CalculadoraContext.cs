namespace StrategyBasico
{
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
}
