using DevRisk.Domain.Enums;

namespace DevRisk.Domain.Entities
{
    public class Category(double riskValue, Status status, ClientSector sector)
    {
        public double RiskValue { get; private set; } = riskValue;
        public Status Status { get; private set; } = status;
        public ClientSector ClientSector { get; private set; } = sector;
    }
}