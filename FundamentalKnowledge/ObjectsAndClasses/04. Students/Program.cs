using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Students
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int studentsCnt = int.Parse(Console.ReadLine());

            List<Student> students = new List<Student>();

            for (int i = 0; i < studentsCnt; i++) 
            {
                string generalInfo = Console.ReadLine();
                string[] studentData = generalInfo.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string firstName = studentData[0];
                string lastName = studentData[1];
                double grade = double.Parse(studentData[2]);

                Student student = new Student()
                {
                    FirstName = firstName,
                    LastName = lastName,
                    Grade = grade,
                };
                
                students.Add(student);
            }

            foreach (var student in students.OrderByDescending(x => x.Grade))
            {
                Console.WriteLine($"{student.FirstName} {student.LastName}: {student.Grade:f2}");
            }   
        }
    }

    public class Student
    { 
    
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public double Grade { get; set; }



    }
}
