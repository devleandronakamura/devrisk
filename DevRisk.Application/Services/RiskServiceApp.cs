using System.Globalization;
using DevRisk.Application.Dtos.Requests;
using DevRisk.Domain.Entities;
using DevRisk.Domain.Services;

namespace DevRisk.Application.Services
{
    public static class RiskServiceApp
    {
        public static List<string> Calculate(string referenceDateRequest, string operationQuantityRequest)
        {
            DateTime referenceDate = Convert.ToDateTime(referenceDateRequest);
            int operationQuantity = Convert.ToInt32(operationQuantityRequest);

            List<Trade> trades = [];

            for (int index = 0; index < operationQuantity; index++)
            {
                Console.WriteLine($"Informe a operação {index + 1}: ");
                string valuesLine = Console.ReadLine();
                string[] parts = valuesLine.Split(' ');

                double value = double.Parse(parts[0]);
                string category = parts[1];
                DateTime nextPaymentDate = DateTime.ParseExact(parts[2], "MM/dd/yyyy", CultureInfo.InvariantCulture);


                trades.Add(new TradeRequest(value, category, nextPaymentDate).ToTrade());
            }

            return RiskServiceDomain.Calculate(trades, referenceDate);
        }
    }
}