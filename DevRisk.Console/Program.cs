using DevRisk.Application.Services;

Console.WriteLine("Informe a data de referência: ");
string date = Console.ReadLine();

Console.WriteLine("Informe a quantidade de operação: ");
string operationQuantity = Console.ReadLine();

List<string> results = RiskServiceApp.Calculate(date, operationQuantity);

foreach (string result in results)
{
    Console.WriteLine(result);
}