using Microsoft.AspNetCore.Mvc;

namespace REST_ASP.NET_Project1NET8.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CalculatorController : ControllerBase
    {
        
        private readonly ILogger<CalculatorController> _logger;

        public CalculatorController(ILogger<CalculatorController> logger)
        {
            _logger = logger;
        }

        [HttpGet("sum/{firstNumber}/{seccondNumber}")]
        public IActionResult Get(string firstNumber, string seccondNumber)
        {
            if (IsNumeric(firstNumber) && IsNumeric(seccondNumber))
            {
                var sum = ConvertToDecimal(firstNumber) + ConvertToDecimal(seccondNumber);
                return Ok(sum.ToString());
            }
            return BadRequest("Invalid Input");
        }

        [HttpGet("difference/{firstNumber}/{seccondNumber}")]
        public IActionResult GetDifference(string firstNumber, string seccondNumber) 
        {
            if(IsNumeric(firstNumber) && IsNumeric(seccondNumber))
            {
                var difference = ConvertToDecimal(firstNumber) - ConvertToDecimal(seccondNumber);
                return Ok(difference.ToString());
            }
            return BadRequest("Invalid Input");
        }

        [HttpGet("product/{firstNumber}/{seccondNumber}")]
        public IActionResult GetProduct(string firstNumber, string seccondNumber)
        {
            if(IsNumeric(firstNumber) && IsNumeric(seccondNumber))
            {
                var product = ConvertToDecimal(firstNumber) * ConvertToDecimal(seccondNumber);
                return Ok(product.ToString());
            }
            return BadRequest("Invalid Input");
        }

        [HttpGet("quotient/{firstNumber}/{seccondNumber}")]
        public IActionResult GetQuotient(string firstNumber, string seccondNumber)
        {
            if(IsNumeric(firstNumber) && IsNumeric(seccondNumber))
            {
                var quotient = ConvertToDecimal(firstNumber) / ConvertToDecimal(seccondNumber);
                return Ok(quotient.ToString());
            }
            return BadRequest("Invalid Input");
        }

        [HttpGet("mean/{fistNumber}/{seccondNumber}")]
        public IActionResult GetMean(string fistNumber, string seccondNumber)
        {
            if(IsNumeric(fistNumber) && IsNumeric(seccondNumber))
            {
                var mean = (ConvertToDecimal(fistNumber) + ConvertToDecimal(seccondNumber)) / 2;
                return Ok(mean.ToString());
            }
            return BadRequest("Invalid Input");
        }

        [HttpGet("squareroot/{number}")]
        public IActionResult GetSquareRoot(string number)
        {
            double radicand;
            if (IsNumeric(number) && double.TryParse(number, out radicand) && radicand >= 0)
            {
                var squareRoot = Math.Sqrt(radicand);
                decimal result = Convert.ToDecimal(squareRoot);
                return Ok(result.ToString());
            }
            return BadRequest("Invalid Input");
        }

        private decimal ConvertToDecimal(string strNumber)
        {
            decimal decimalValue;
            if (decimal.TryParse(strNumber, out decimalValue))
            {
                return decimalValue;
            }
            return 0;
        }

        private bool IsNumeric(string strNumber)
        {
            double number;
            bool isNumber = double.TryParse(strNumber, 
                System.Globalization.NumberStyles.Any, 
                System.Globalization.NumberFormatInfo.InvariantInfo, 
                out number);
            return isNumber;
        }
    }
}
