
Dictionary<string, List<string>> keyValuePairs = new Dictionary<string, List<string>>();

string input = " ";

while ((input = Console.ReadLine()) != "end")
{
    string[] cmdArgs = input.Split(":", StringSplitOptions.RemoveEmptyEntries);
    string courseName = cmdArgs[0].Trim();
    string studentName = cmdArgs[1].Trim();

    if (!keyValuePairs.ContainsKey(courseName))
    {
        keyValuePairs.Add(courseName, new List<string>());
    }

    keyValuePairs[courseName].Add(studentName);
}

foreach (var course in keyValuePairs)
{
    string courseName = course.Key;
    var students = course.Value;
    Console.WriteLine($"{course.Key}: {students.Count}");
    foreach (var student in students)
    {
        Console.WriteLine($"-- {student}");
    }
}


