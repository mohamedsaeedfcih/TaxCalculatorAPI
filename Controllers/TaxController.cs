using Microsoft.AspNetCore.Mvc;
using TaxCalculatorAPI.Models;
using TaxCalculatorAPI.Services;

namespace TaxCalculatorAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TaxController : ControllerBase
    {
        private readonly ITaxCalculatorService _taxCalculatorService;

        public TaxController(ITaxCalculatorService taxCalculatorService)
        {
            _taxCalculatorService = taxCalculatorService;
        }

        /// <summary>
        /// Calculates the tax based on the provided income and deductions.
        /// </summary>
        /// <param name="request">Tax request containing the income and deductions.</param>
        /// <returns>Tax response with the calculated tax amount and details.</returns>
        [HttpPost("calculate")]
        [ProducesResponseType(typeof(TaxResponse), 200)]
        [ProducesResponseType(400)]
        public ActionResult<TaxResponse> CalculateTax([FromBody] TaxRequest request)
        {
            if (request.Income < 0 || request.Deductions < 0)
            {
                return BadRequest("Income and deductions must be positive values.");
            }

            var result = _taxCalculatorService.CalculateTax(request.Income, request.Deductions);
            var response = new TaxResponse
            {
                Income = result.Income,
                Deductions = result.Deductions,
                TaxableIncome = result.TaxableIncome,
                TaxAmount = result.TaxAmount
            };

            return Ok(response);
        }
    }
}
