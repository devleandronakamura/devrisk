namespace DevRisk.Console.Domain.Interfaces
{
    public interface ITradeCategory
    {
        string Name { get; }
        bool IsInCategory(ITrade trade);
    }
}