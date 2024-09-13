using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.CostСalculation
{
    public class CalculationPriceDto
    {
        public int EstimatedValue { get; set; }
        public int Weight { get; set; }
        public int Height { get; set; }
        public int Length { get; set; }
        public int Width { get; set; }
        public int Remittance { get; set; }
        public bool Packaging { get; set; }
        public bool PlaceDispatch { get; set; }
        public bool PlaceReceipt { get; set; }

    }
}
