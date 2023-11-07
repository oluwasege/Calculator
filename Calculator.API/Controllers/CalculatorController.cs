using Clalculator.Service.Interfaces;
using Clalculator.Service.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Calculator.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CalculatorController : ControllerBase
    {
        private readonly ICalculationService _calculatorService;

        public CalculatorController(ICalculationService calculationService)
        {
            _calculatorService = calculationService;
        }

        [HttpPost]
        public async Task<IActionResult> PerformCalculation([FromBody]CalculationVM model)
        {

        }
    }
}
