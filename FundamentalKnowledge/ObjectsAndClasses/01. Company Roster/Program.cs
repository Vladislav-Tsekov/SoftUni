


int numberOfEmployees = int.Parse(Console.ReadLine());

List<Employee> employees = new List<Employee>();    

for (int i = 0; i < numberOfEmployees; i++) 
{
    string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
    string name = input[0];
    double salary = double.Parse(input[1]);
    string department = input[2];

    Employee employee = new(name, salary, department);
    employees.Add(employee);
}

SortedList<string, double> highestPaidDepartment = new();

foreach (var item in employees) 
{
    if (highestPaidDepartment.ContainsKey(item.Department))
        highestPaidDepartment[item.Department] += item.Salary;
    else
        highestPaidDepartment.Add(item.Department, item.Salary);
}

var highestPay = highestPaidDepartment.OrderByDescending(e => e.Value).First();
Console.WriteLine($"Highest Average Salary: {highestPay.Key}");

var sortedEmployees = employees.OrderByDescending(s => s.Salary);

foreach (var employee in sortedEmployees)
{
    if (employee.Department == highestPay.Key)
    {
        Console.WriteLine($"{employee.Name} {employee.Salary:f2}");
    }
}

public class Employee
{
    public string Name { get; set; }
    public double Salary { get; set; }
    public string Department { get; set; }

    public Employee(string name, double salary, string department)
    {
        Name = name;
        Salary = salary;
        Department = department;
    }
}