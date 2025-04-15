using DevRisk.Console.Domain.Interfaces;

namespace DevRisk.Console.Domain.Services
{
    public class TradeClassifier(params ITradeCategory[] categories)
    {
        public string ClassifyTrade(ITrade trade)
        {
            foreach (var category in categories)
            {
                if (category.IsInCategory(trade))
                {
                    return category.Name;
                }
            }
            return "UNCLASSIFIED";
        }
    }
}