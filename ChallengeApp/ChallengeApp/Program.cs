using ChallengeApp;

Employee employee1 = new Employee("Adam", "Kowalski", "32");
Employee employee2 = new Employee("Monika", "Nowak", "40");
Employee employee3 = new Employee("Zuzia", "Nocoń", "23");


employee1.AddScore(5);
employee1.AddScore(2);
employee1.AddScore(2);
employee1.AddScore(1);
employee1.AddScore(3);

employee2.AddScore(4);
employee2.AddScore(7);
employee2.AddScore(8);
employee2.AddScore(4);
employee2.AddScore(9);

employee3.AddScore(7);
employee3.AddScore(8);
employee3.AddScore(9);
employee3.AddScore(9);
employee3.AddScore(9);

var result1 = employee1.Result;
var result2 = employee2.Result;
var result3 = employee3.Result;
   
List<Employee> employees = new List<Employee>()
{
employee1, employee2, employee3
};
int maxResult = 0;
Employee? employeeWithMaxResult = null;
foreach (var employee in employees)
{
    if(employee.Result > maxResult)
    {
        employeeWithMaxResult = employee;
        maxResult = employee.Result;
    }
}
Console.WriteLine("The best score has: " + employeeWithMaxResult.Name +" "+ employeeWithMaxResult.Surname);
Console.WriteLine("Age: " + employeeWithMaxResult.Age);
Console.WriteLine("Score: " + maxResult);
Console.WriteLine("Congratulations!");
Console.WriteLine("");
Console.WriteLine("SUMMARY: ");
Console.WriteLine("Employee 1 is: " + employee1.Name + " " + employee1.Surname + " " + "age: " + employee1.Age + " " + "score: " + employee1.Result);
Console.WriteLine("Employee 2 is: " + employee2.Name + " " + employee2.Surname + " " + "age: " + employee2.Age + " " + "score: " + employee2.Result);
Console.WriteLine("Employee 3 is: " + employee3.Name + " " + employee3.Surname + " " + "age: " + employee3.Age + " " + "score: " + employee3.Result);
Console.WriteLine("");
Console.WriteLine("Thank you and see you!");