using ChallengeApp;

Console.WriteLine("Witamy w programie do oceny pracownika");
Console.WriteLine("==========================================");
Console.WriteLine();



var employee = new Employee();

while (true)
{
    Console.WriteLine();
    Console.WriteLine("Podaj kolejną ocenę pracownika:");
    Console.WriteLine("Jeśli chcesz zakończyć dodawanie ocen wpisz literę q");
    Console.WriteLine();
    var input = Console.ReadLine();
    if (input == "q")
    {
        break;
    }
    employee.AddGrade(input);
}

var statistics = employee.GetStatistics();
Console.WriteLine(statistics.Average);
Console.WriteLine($"Average: {statistics.Average}");
Console.WriteLine($"AverageLetter: {statistics.AverageLetter}");
Console.WriteLine($"Min: {statistics.Min}");
Console.WriteLine($"Max: {statistics.Max}");