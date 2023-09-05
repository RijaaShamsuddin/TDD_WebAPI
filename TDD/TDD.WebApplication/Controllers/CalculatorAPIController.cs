using Microsoft.AspNetCore.Mvc;
using TDD.Logics;

namespace TDD.WebApplication.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CalculatorAPIController : ControllerBase
    {
        private readonly ICalculator _calculator;

        public CalculatorAPIController()
        {
            _calculator = new Calculator();
        }

        [HttpGet("api/calculator/add/{num1}/{num2}")]
        public IActionResult GetCalculatorAdd(int num1, int num2)
        {
            int result = _calculator.Add(num1,num2);
            return Ok(result);
        }

        [HttpGet("api/calculator/subtract/{num1}/{num2}")]
        public IActionResult GetCalculatorSubtract(int num1, int num2)
        {
            int result = _calculator.Subtract(num1, num2);
            return Ok(result);
        }

        [HttpGet("api/calculator/multiply/{num1}/{num2}")]
        public IActionResult GetCalculatorMultiply(int num1, int num2)
        {
            int result = _calculator.Multiply(num1, num2);
            return Ok(result);
        }

        [HttpGet("api/calculator/divide/{num1}/{num2}")]
        public IActionResult GetCalculatorDivide(int num1, int num2)
        {           
            try
            {
                int result = _calculator.Divide(num1, num2);
                return Ok(result);
            }
            catch (DivideByZeroException ex)
            {
                return BadRequest(ex.Message);
            }
            catch (ArgumentException ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
