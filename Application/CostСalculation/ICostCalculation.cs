using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.CostСalculation
{
    public interface ICostCalculation
    {
        decimal CalculateCost(decimal estimatedValue, string placeDispatch, string placeReceipt, decimal weight, decimal length, decimal width, decimal height, bool packagingRequired, bool cashOnDelivery);
    }
}
