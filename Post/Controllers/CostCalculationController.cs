using Application.CostCalculation;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.CostСalculation
{
    [ApiController]
    [Route("[controller]")]
    public class CostCalculationController : ControllerBase
    {
        private readonly ICostCalculation _costCalculationService;
        
        public CostCalculationController(ICostCalculation costCalculationService)
        {
            _costCalculationService = costCalculationService;
        }

        // POST /CostCalculation/calculate
        [HttpPost("calculate")]
        public IActionResult CalculateCost([FromBody] CostCalculationRequest request)
        {
            try
            {
                decimal cost = _costCalculationService.CalculateCost(
                    request.EstimatedValue,
                    request.PlaceDispatch,
                    request.PlaceReceipt,
                    request.Weight,
                    request.Length,
                    request.Width,
                    request.Height,
                    request.PackagingRequired,
                    request.CashOnDelivery
                );

                return Ok(new { totalCost = cost });
            }
            catch (ArgumentException ex)
            {
                return BadRequest(new { errorText = ex.Message });
            }
        }
    }

    public class CostCalculationRequest
    {
        public decimal EstimatedValue { get; set; }
        public string PlaceDispatch { get; set; }
        public string PlaceReceipt { get; set; }
        public decimal Weight { get; set; }
        public decimal Length { get; set; }
        public decimal Width { get; set; }
        public decimal Height { get; set; }
        public bool PackagingRequired { get; set; }
        public bool CashOnDelivery { get; set; }
    }
}
