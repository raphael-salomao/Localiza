using System.Collections.Generic;
using Localiza.Hertz.Tools.Calculator.Calculations.Implementation.Results;

namespace Localiza.Hertz.Tools.Calculator.Calculations.Implementation.Calculations
{
    public class PrimeNumber
    {
        private readonly ICalculate _calculate;

        public PrimeNumber(ICalculate calculate)
        {
            _calculate = calculate;
        }

        public IResultPrimeNumbers Calculate()
        {
            return CalculatePrimeNumbers();
        }

        private IResultPrimeNumbers CalculatePrimeNumbers()
        {
            var result = new List<decimal>();

            return new ResultPrimeNumbers(result);
        }
    }
}
