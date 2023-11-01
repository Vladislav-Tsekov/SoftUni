namespace _05._Students_2._0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string cmd = "";

            List<Students> allStudents = new List<Students>();

            while ((cmd = Console.ReadLine()) != "end") 
            {
                string[] cmdArgs = cmd.Split(" ", StringSplitOptions.RemoveEmptyEntries); 
                string firstName = cmdArgs[0];
                string lastName = cmdArgs[1];
                int age = int.Parse(cmdArgs[2]);
                string hometown = cmdArgs[3];

                bool studentExists = false;

                foreach (var student in allStudents)
                {
                    if (student.FirstName == firstName && student.LastName == lastName)
                    {
                        studentExists = true;
                        break;
                    }
                }

                if (studentExists)
                {
                    foreach (var student in allStudents)
                    {
                        if (student.FirstName == firstName && student.LastName == lastName)
                        {
                            student.Age = age;
                            student.HomeTown = hometown;
                        }
                    }
                }
                else
                {
                    Students student = new Students
                    {
                        FirstName = firstName,
                        LastName = lastName,
                        Age = age,
                        HomeTown = hometown,
                    };

                    allStudents.Add(student);
                }
                
            }

            string searchedCity = Console.ReadLine();

            foreach (Students student in allStudents)
            {
                if (student.HomeTown == searchedCity)
                {
                    Console.WriteLine($"{student.FirstName} {student.LastName} is {student.Age} years old.");
                }
            }


        }
    }

    public class Students
    { 
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string HomeTown { get; set; }
    }
}