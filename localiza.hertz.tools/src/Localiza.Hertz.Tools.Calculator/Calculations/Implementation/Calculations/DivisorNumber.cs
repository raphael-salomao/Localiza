using System.Collections.Generic;
using Localiza.Hertz.Tools.Calculator.Calculations.Implementation.Results;

namespace Localiza.Hertz.Tools.Calculator.Calculations.Implementation.Calculations
{
    public class DivisorNumber
    {
        private readonly ICalculate _calculate;

        public DivisorNumber(ICalculate calculate)
        {
            _calculate = calculate;
        }

        public IResultDivisorNumbers Calculate()
        {
            return CalculateDivisorNumbers();
        }

        private IResultDivisorNumbers CalculateDivisorNumbers()
        {
            var result = new List<decimal>();

            return new ResultDivisorNumbers(result);
        }
    }
}