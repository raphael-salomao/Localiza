using Localiza.Hertz.Tools.Calculator.Calculations;
using Localiza.Hertz.Tools.Calculator.Calculations.Implementation.Calculations;

namespace Localiza.Hertz.Tools.Calculator.Facade
{
    public class FacadeCalculator
    {
        private readonly ICalculate _calculate;

        public FacadeCalculator(ICalculate calculate)
        {
            _calculate = calculate;
        }

        public IResultDivisorNumbers CalculateDivisorNumbers()
        {
            return new DivisorNumber(_calculate).Calculate();
        }

        public IResultPrimeNumbers CalculatePrimeNumbers()
        {
            return new PrimeNumber(_calculate).Calculate();
        }
    }
}