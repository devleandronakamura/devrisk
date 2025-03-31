using DevRisk.Domain.Entities;
using DevRisk.Domain.Enums;

namespace DevRisk.Application.Dtos.Requests
{
    public class TradeRequest(double value, string clientSector, DateTime nextPaymentDate)
    {
        public double Value { get; private set; } = value;
        public string ClientSector { get; private set; } = clientSector;
        public DateTime NextPaymentDate { get; private set; } = nextPaymentDate;

        public Trade ToTrade()
        {
            return new Trade(value, Enum.Parse<ClientSector>(ClientSector), nextPaymentDate);
        }
    }
}