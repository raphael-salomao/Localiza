using System;
using Localiza.Hertz.Tools.Calculator.Calculations.Implementation;
using Localiza.Hertz.Tools.Calculator.Facade;
using Microsoft.AspNetCore.Mvc;

namespace Localiza.Hertz.Numbers.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PrimeNumbersController : ControllerBase
    {
        public PrimeNumbersController()
        {
        }

        /// <summary>
        /// Verifica se o número é primo.
        /// </summary>
        /// <param name="number">Número inteiro maior que zero.</param>
        /// <returns></returns>
        [HttpGet("{number:decimal}")]
        [ProducesResponseType(typeof(bool), 200)]
        public bool Get(decimal number)
        {
            if (number > 0)
            {
                var calculate = new Calculate
                {
                    InputNumber = number
                };

                var facade = new FacadeCalculator(calculate);

                var result = facade.CalculatePrimeNumbers();

                return result.IsPrime;
            }
            else
                throw new ArgumentException($"O número deve ser maior que zero.");
        }
    }
}