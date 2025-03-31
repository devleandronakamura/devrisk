using DevRisk.Domain.Enums;
using DevRisk.Domain.Interfaces;

namespace DevRisk.Domain.Entities
{
    public class Trade(double value, ClientSector sector, DateTime nextPaymentDate) : ITrade
    {
        private const int DAYS_TO_EXPIRE = 30;

        public double Value { get; private set; } = value;
        public DateTime NextPaymentDate { get; private set; } = nextPaymentDate;
        public ClientSector ClientSector { get; private set; } = sector;

        public bool IsExpired(DateTime referenceDate)
        {
            return referenceDate.Date.AddDays(DAYS_TO_EXPIRE).Date > NextPaymentDate;
        }
    }
}