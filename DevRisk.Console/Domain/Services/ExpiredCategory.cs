using DevRisk.Console.Domain.Interfaces;

namespace DevRisk.Console.Domain.Services
{
    public class ExpiredCategory(DateTime referenceDate) : ITradeCategory
    {
        private const int DAYS_TO_EXPIRE = 30;

        public string Name => "EXPIRED";

        public bool IsInCategory(ITrade trade)
        {
            return referenceDate.Date.AddDays(DAYS_TO_EXPIRE).Date > trade.NextPaymentDate.Date;
        }
    }
}