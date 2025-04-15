using DevRisk.Console.Domain.Interfaces;

namespace DevRisk.Console.Domain.Services
{
    public class MediumRiskCategory : ITradeCategory
    {
        public string Name => "MEDIUMRISK";

        public bool IsInCategory(ITrade trade)
        {
            return trade.Value > 1000000 && trade.ClientSector == "Public";
        }
    }
}