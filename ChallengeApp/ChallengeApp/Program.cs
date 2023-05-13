using ChallengeApp;

var employee = new Employee("Dawid", "P.");
employee.AddGrade("Dawid");
employee.AddGrade("5000");
employee.AddGrade(6);
employee.AddGrade(6);
var statistics = employee.GetStatistics();
Console.WriteLine($"Average: {statistics.Average:N2}");
Console.WriteLine($"Min: {statistics.Min}");
Console.WriteLine($"Max: {statistics.Max}");