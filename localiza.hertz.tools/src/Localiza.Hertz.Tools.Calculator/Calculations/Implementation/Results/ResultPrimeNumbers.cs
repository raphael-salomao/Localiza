namespace Localiza.Hertz.Tools.Calculator.Calculations.Implementation.Results
{
    public class ResultPrimeNumbers : IResultPrimeNumbers
    {
        public ResultPrimeNumbers(bool isPrime)
        {
            IsPrime = isPrime;
        }

        public bool IsPrime { get; set; }
    }
}