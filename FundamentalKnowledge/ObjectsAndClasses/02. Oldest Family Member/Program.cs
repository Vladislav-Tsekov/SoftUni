using System.Text;

int n = int.Parse(Console.ReadLine());
List<Person> people = new();

for (int i = 0; i < n; i++) 
{
    string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
    string name = input[0];
    int age = int.Parse(input[1]);
    Person person = new (name, age);
    Family.AddMember(person);
}

Console.WriteLine(Family.GetOldestMember());

public class Family 
{
    public static List<Person> People = new();
    public static void AddMember(Person person) 
    {
        People.Add(person);
    }
    public static string GetOldestMember() 
    {
        var oldestMember = People.OrderByDescending(p => p.Age).First();
        StringBuilder sb = new StringBuilder();
        sb.AppendLine($"{oldestMember.Name} {oldestMember.Age}").ToString();
        return sb.ToString();
    }
    public Family(List<Person> people)
    {
        People = people;
    }
}

public class Person 
{
    public string Name { get; set; }
    public int Age { get; set; }

    public Person(string name, int age)
    {
        Name = name;
        Age = age;
    }
}