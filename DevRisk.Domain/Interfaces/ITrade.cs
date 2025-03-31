using DevRisk.Domain.Enums;

namespace DevRisk.Domain.Interfaces
{
    public interface ITrade
    {
        double Value { get; }
        ClientSector ClientSector { get; }
        DateTime NextPaymentDate { get; }
    }
}