using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Cache;
using System.Text;
using System.Threading.Tasks;
using DefiningClasses;

public class StartUp
{
    public static void Main(string[] args)
    {
        Family family = new Family();

        int count = int.Parse(Console.ReadLine());

        for (int i = 0; i < count; i++)
        {
            string[] data = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            //string name = data[0];
            //int age = int.Parse(data[1]);

            Person person = new Person(data[0], int.Parse(data[1]));
            family.AddMember(person);
        }
        Person oldest = family.GetOldestMember();
        Console.WriteLine($"{oldest.Name} {oldest.Age}");
    }
}



