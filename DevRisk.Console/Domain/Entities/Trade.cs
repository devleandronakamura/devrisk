using DevRisk.Console.Domain.Interfaces;

namespace DevRisk.Console.Domain.Entities
{
    public class Trade : ITrade
    {
        public Trade(double value, string clientSector, DateTime nextPaymentDate)
        {
            Value = value;
            ClientSector = clientSector;
            NextPaymentDate = nextPaymentDate;
        }

        public double Value { get; private set; }
        public string ClientSector { get; private set; }
        public DateTime NextPaymentDate { get; private set; }
    }
}