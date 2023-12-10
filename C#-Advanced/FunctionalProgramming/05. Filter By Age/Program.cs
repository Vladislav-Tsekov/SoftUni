
int n = int.Parse(Console.ReadLine());
List<Person> people = new List<Person>();

GetInputData(n, people);

string condition =  Console.ReadLine();
int age = int.Parse(Console.ReadLine());
string format = Console.ReadLine();

PrintInNameAgeFormat(people, condition, age, format);

PrintInNameFormat(people, condition, age, format);

PrintInAgeFormat(people, condition, age, format);

static void GetInputData(int n, List<Person> people)
{
    for (int i = 0; i < n; i++)
    {
        string[] data = Console.ReadLine()
            .Split(", ", StringSplitOptions.RemoveEmptyEntries);
        Person currentPerson = new Person()
        {
            Name = data[0],
            Age = int.Parse(data[1])
        };
        people.Add(currentPerson);
    }
}

static void PrintInNameAgeFormat(List<Person> people, string condition, int age, string format)
{
    if (format == "name age")
    {
        foreach (var person in people)
        {
            if (condition == "older" && person.Age >= age)
            {
                Console.Write($"{person.Name} - {person.Age}\n");
            }
            else if (condition == "younger" && person.Age < age)
            {
                Console.Write($"{person.Name} - {person.Age}\n");
            }
        }
    }
}

static void PrintInNameFormat(List<Person> people, string condition, int age, string format)
{
    if (format == "name")
    {
        foreach (var person in people)
        {
            if (condition == "older" && person.Age >= age)
            {
                Console.Write($"{person.Name}\n");
            }
            else if (condition == "younger" && person.Age < age)
            {
                Console.Write($"{person.Name}\n");
            }
        }
    }
}

static void PrintInAgeFormat(List<Person> people, string condition, int age, string format)
{
    if (format == "age")
    {
        foreach (var person in people)
        {
            if (condition == "older" && person.Age >= age)
            {
                Console.Write($"{person.Age}\n");
            }
            else if (condition == "younger" && person.Age < age)
            {
                Console.Write($"{person.Age}\n");
            }
        }
    }
}

public class Person
{
    public string Name { get; set; }
    public int Age { get; set; }
}