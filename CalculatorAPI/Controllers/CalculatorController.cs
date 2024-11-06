using Calculator.Model;
using Calculator.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Calculator.Controllers
{
    [Route("api/calculator")]
    [ApiController]
    public class CalculatorController : ControllerBase
    {
        private readonly ICalculatorService _calculatorService;

        public CalculatorController(ICalculatorService calculatorService)
        {
            _calculatorService = calculatorService;
        }
        
        [HttpPost]
        [Route("Operate")]
        public ActionResult<double> CalculattionOperate(CalculationRequestDto requestDto)
        {
            if (requestDto == null)
                return BadRequest("Invalid request");
            try
            {
                var result = _calculatorService.DoCalculate(requestDto.Param1, requestDto.Param2, requestDto.Operation);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
