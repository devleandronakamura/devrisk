using DevRisk.Console.Domain.Services;

Console.WriteLine("Informe a data de referência: ");
string date = Console.ReadLine();

Console.WriteLine("Informe a quantidade de operação: ");
string operationQuantity = Console.ReadLine();

RiskServiceApp.Classify(date, operationQuantity);