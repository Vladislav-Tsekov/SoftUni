using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiningClasses;

public class StartUp
{
    public static void Main(string[] args)
    { 
        int n = int.Parse(Console.ReadLine());
        List<Person> people = new List<Person>();

        for (int i = 0; i < n; i++)
        {
            string[] data = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            Person person = new Person(data[0], int.Parse(data[1]));
            people.Add(person);
        }

        var sortedPeople = people.Where(p => p.Age > 30).OrderBy(p => p.Name);
        foreach (var person in sortedPeople)
        {
            Console.WriteLine($"{person.Name} - { person.Age}");
        }
    }
}
