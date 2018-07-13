using StrategyBasico2.CalculadoraEngine;

namespace StrategyBasico2
{
    public class CalculadoraContext
    {
        ICalculoStrategy _calculoStrategy;

        public CalculadoraContext(TipoCalculo tipoCalculo)
        {
            switch (tipoCalculo)
            {
                case TipoCalculo.Suma:
                    _calculoStrategy = new Suma();
                    break;
                case TipoCalculo.Resta:
                    _calculoStrategy = new Resta();
                    break;
                case TipoCalculo.Multiplicacion:
                    _calculoStrategy = null;
                    break;
                default:
                    break;
            }
        }

        public int EjecutarCalculo(int numero1, int numero2)
        {
            return _calculoStrategy.Calcular(numero1, numero2);
        }
    }
}
