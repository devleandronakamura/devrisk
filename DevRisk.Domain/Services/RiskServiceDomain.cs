using DevRisk.Domain.Entities;
using DevRisk.Domain.Enums;
using DevRisk.Domain.Repositories;

namespace DevRisk.Domain.Services
{
    public static class RiskServiceDomain
    {
        public static List<string> Calculate(List<Trade> trades, DateTime referenceDate)
        {
            List<string> results = [];
            List<Category> categories = RiskRepository.GetDefaultParams();

            foreach (Trade trade in trades)
            {
                if (trade.IsExpired(referenceDate))
                {
                    results.Add(Status.EXPIRED.ToString());
                    continue;
                }

                Category? category = categories.SingleOrDefault(x => x.ClientSector == trade.ClientSector && trade.Value > x.RiskValue);

                if (category is null)
                {
                    results.Add(Status.NONE.ToString());
                    continue;
                }

                results.Add(category.Status.ToString());
            }

            return results;
        }
    }
}