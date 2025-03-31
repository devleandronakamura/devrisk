using DevRisk.Domain.Entities;
using DevRisk.Domain.Enums;

namespace DevRisk.Domain.Repositories
{
    public static class RiskRepository
    {
        public static List<Category> GetDefaultParams()
        {
            return
            [
                new(1_000, Status.MEDIUMRISK, ClientSector.Public),
                new(1_000, Status.HIGHRISK, ClientSector.Private),
            ];
        }
    }
}