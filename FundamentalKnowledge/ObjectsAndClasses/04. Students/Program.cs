namespace _04._Students
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

                Students student = new Students();

                student.FirstName = cmdArgs[0];
                student.LastName = cmdArgs[1];
                student.Age = int.Parse(cmdArgs[2]);
                student.Hometown = cmdArgs[3];

                allStudents.Add(student);
            }

            string searchedCity = Console.ReadLine();

            foreach (Students student in allStudents)
            {
                if (student.Hometown == searchedCity)
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
        public string Hometown { get; set; }
    }

}