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
            var div = 2;

            while (_calculate.InputNumber > 1)
            {
                if ((_calculate.InputNumber % div) == 0)
                {
                    _calculate.InputNumber = (_calculate.InputNumber / div);
                    result.Add(div);
                } else
                {
                    div++;
                }
            }

            return new ResultDivisorNumbers(result);
        }
    }
}