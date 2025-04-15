using System.Globalization;
using DevRisk.Console.Domain.Entities;
using DevRisk.Console.Domain.Interfaces;

namespace DevRisk.Console.Domain.Services
{
    public static class RiskServiceApp
    {
        public static void Classify(string referenceDateRequest, string operationQuantityRequest)
        {
            DateTime referenceDate = Convert.ToDateTime(referenceDateRequest);
            int operationQuantity = Convert.ToInt32(operationQuantityRequest);

            List<ITrade> trades = [];

            for (int index = 0; index < operationQuantity; index++)
            {
                System.Console.WriteLine($"Informe a operação {index + 1}: ");
                string valuesLine = System.Console.ReadLine();
                string[] parts = valuesLine.Split(' ');

                double value = double.Parse(parts[0]);
                string category = parts[1];
                DateTime nextPaymentDate = DateTime.ParseExact(parts[2], "MM/dd/yyyy", CultureInfo.InvariantCulture);


                trades.Add(new Trade(value, category, nextPaymentDate));
            }

            TradeClassifier classifier = new TradeClassifier(new ExpiredCategory(referenceDate), new HighRiskCategory(), new MediumRiskCategory());

            foreach (var trade in trades)
            {
                System.Console.WriteLine(classifier.ClassifyTrade(trade));
            }
        }
    }
}