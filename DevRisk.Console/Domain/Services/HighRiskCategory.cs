using DevRisk.Console.Domain.Interfaces;

namespace DevRisk.Console.Domain.Services
{
    public class HighRiskCategory : ITradeCategory
    {
        public string Name => "HIGHRISK";

        public bool IsInCategory(ITrade trade)
        {
            return trade.Value > 1000000 && trade.ClientSector == "Private";
        }
    }
}