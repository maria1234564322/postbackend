using System;

namespace Application.CostCalculation
{
    public class CostCalculationService
    {
        public decimal CalculateCost(decimal estimatedValue, string placeDispatch, string placeReceipt, decimal weight, decimal length, decimal width, decimal height, bool packagingRequired, bool cashOnDelivery)
        {
            decimal estimatedValueCoefficient = 0m;

            // коефіцієнт оголошеної цінності
            if (estimatedValue >= 0 && estimatedValue <= 10000)
            {
                estimatedValueCoefficient = 10m;
            }
            else if (estimatedValue > 10000 && estimatedValue <= 50000)
            {
                estimatedValueCoefficient = 50m;
            }
            else if (estimatedValue > 50000 && estimatedValue <= 150000)
            {
                estimatedValueCoefficient = 100m;
            }
            else if (estimatedValue > 150000 && estimatedValue <= 200000)
            {
                estimatedValueCoefficient = 150m;
            }

            // коефіцієнт відстані
            decimal distanceCoefficient = 0m;

            if (placeDispatch == "Відділення" && placeReceipt == "Відділення")
            {
                distanceCoefficient = 50m;
            }
            else if (placeDispatch == "Відділення" && placeReceipt == "Кур'єр")
            {
                distanceCoefficient = 100m;
            }
            else if (placeDispatch == "Відділення" && placeReceipt == "Поштомат")
            {
                distanceCoefficient = 40m;
            }
            else if (placeDispatch == "Кур'єр" && placeReceipt == "Кур'єр")
            {
                distanceCoefficient = 150m;
            }
            else if (placeDispatch == "Поштомат" && placeReceipt == "Поштомат")
            {
                distanceCoefficient = 40m;
            }

            // Обчислення об'ємної ваги
            decimal volumetricWeight = (length * width * height) / 5000;

            // Порівняння фактичної ваги та об'ємної
            decimal finalWeight = Math.Max(weight, volumetricWeight);

            // Додаємо ваговий коефіцієнт до вартості
            decimal weightCoefficient = finalWeight * 5; // Припустимо, що тариф 5 грн за кг

            // Вартість пакування
            decimal packagingCost = 0m;
            if (packagingRequired)
            {
                packagingCost = 20m; // Наприклад, фіксована вартість пакування 20 грн
            }

            // Вартість зворотної доставки коштів
            decimal cashOnDeliveryCost = 0m;
            if (cashOnDelivery)
            {
                cashOnDeliveryCost = 30m; // Наприклад, фіксована вартість 30 грн за зворотну доставку коштів
            }

            // Розрахунок загальної вартості
            decimal cost = estimatedValueCoefficient + distanceCoefficient + weightCoefficient + packagingCost + cashOnDeliveryCost;

            return cost;
        }

    }
}

