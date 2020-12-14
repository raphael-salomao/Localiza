using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace Localiza.Hertz.Numbers.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PrimeNumbersController : ControllerBase
    {
        public PrimeNumbersController()
        {
            //DivisorNumber
        }

        [HttpGet("{id:decimal}")]
        [ProducesResponseType(typeof(decimal), 200)]
        public IEnumerable<decimal> Get(decimal number)
        {
            return new List<decimal>() { 1,5,9};
        }
    }
}