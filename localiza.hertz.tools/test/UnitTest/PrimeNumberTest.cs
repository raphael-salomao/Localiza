using System.Collections.Generic;
using Localiza.Hertz.Tools.Calculator.Calculations.Implementation;
using Localiza.Hertz.Tools.Calculator.Facade;
using Xunit;

namespace UnitTest
{
    public class PrimeNumberTest
    {
        [Fact]
        public void Test()
        {
            var calculate = new Calculate
            {
                InputNumber = 200
            };

            var facade = new FacadeCalculator(calculate);

            var result = facade.CalculateDivisorNumbers();

            var primes = new List<decimal>();

            foreach (var item in result.Numbers)
            {
                var isPrime = new FacadeCalculator(new Calculate() { InputNumber = item }).CalculatePrimeNumbers().IsPrime;

                if (isPrime)
                {
                    primes.Add(item);
                }
            }
        }
    }
}