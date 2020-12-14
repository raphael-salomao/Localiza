using System;
using System.Collections.Generic;
using Localiza.Hertz.Tools.Calculator.Calculations.Implementation;
using Localiza.Hertz.Tools.Calculator.Facade;
using Microsoft.AspNetCore.Mvc;

namespace Localiza.Hertz.Numbers.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DivisorNumbersController : ControllerBase
    {
        public DivisorNumbersController()
        {
        }

        /// <summary>
        /// Calcular todos os divisores que compõem o número.
        /// </summary>
        /// <param name="number">Número inteiro maior que zero.</param>
        /// <returns></returns>
        [HttpGet("{number:decimal}")]
        [ProducesResponseType(typeof(decimal), 200)]
        public IEnumerable<decimal> Get(decimal number)
        {
            if (number > 0)
            {
                var calculate = new Calculate
                {
                    InputNumber = number
                };

                var facade = new FacadeCalculator(calculate);

                var result = facade.CalculateDivisorNumbers();

                return result.Numbers;
            }
            else
                throw new ArgumentException($"O número deve ser maior que zero.");
        }
    }
}
