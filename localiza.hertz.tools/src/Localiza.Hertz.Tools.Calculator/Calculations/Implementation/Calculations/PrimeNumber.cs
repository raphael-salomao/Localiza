using System.Collections.Generic;
using System.Linq;
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
            var number = _calculate.InputNumber;
            var result = new List<decimal>();
            var div = 1;

            while (_calculate.InputNumber > 1)
            {
                if ((_calculate.InputNumber % div) == 0)
                {
                    _calculate.InputNumber = (_calculate.InputNumber / div);
                    result.Add(div);
                }
                else
                {
                    div++;
                }
            }

            return new ResultPrimeNumbers(result.Count() == 2 && result.LastOrDefault() == number);
        }
    }
}
