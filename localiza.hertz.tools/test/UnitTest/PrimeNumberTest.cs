using System.Linq;
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
                InputNumber = 40
            };

            var facade = new FacadeCalculator(calculate);

            var result = facade.CalculatePrimeNumbers();

            Assert.Equal(1000.00m, result.Numbers.Sum());
        }
    }
}