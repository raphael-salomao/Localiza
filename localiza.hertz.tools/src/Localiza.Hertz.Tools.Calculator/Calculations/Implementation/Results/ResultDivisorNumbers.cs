using System.Collections.Generic;

namespace Localiza.Hertz.Tools.Calculator.Calculations.Implementation.Results
{
    public class ResultDivisorNumbers : IResultDivisorNumbers
    {
        public ResultDivisorNumbers(List<decimal> numbers)
        {
            Numbers = numbers;
        }

        public List<decimal> Numbers { get; set; }
    }
}