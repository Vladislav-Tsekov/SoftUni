using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._Order_by_Age
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string cmd = string.Empty;
            List<Person> listOfPeople = new List<Person>();
            
            while ((cmd = Console.ReadLine()) != "End")
            {
                string[] cmdArg = cmd.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string name = cmdArg[0];
                string ID = cmdArg[1];
                int age = int.Parse(cmdArg[2]);

                Person currentPerson = new Person()
                { 
                    Name = name,
                    ID = ID,
                    Age = age,
                };

                listOfPeople.Add(currentPerson);

                foreach (Person person in listOfPeople)
                {
                    if (person.ID.Contains(ID))
                    {
                        person.Name = name;
                        person.Age = age;
                    }
                }               
            }

            List<Person> validList = listOfPeople.OrderBy(x => x.Age).ToList();

            foreach (var person in validList)
            {
                Console.WriteLine($"{person.Name} with ID: {person.ID} is {person.Age} years old.");
            }
            //Stephen with ID: 524244 is 10 years old.
        }
    }

    public class Person 
    {
        public string Name { get; set; }
        public string ID { get; set; }
        public int Age { get; set; }
        
    }
}
