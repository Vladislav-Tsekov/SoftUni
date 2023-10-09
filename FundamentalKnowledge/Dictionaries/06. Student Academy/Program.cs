

Dictionary<string, List<double>> keyValuePairs = new Dictionary<string, List<double>>();
Dictionary<string, double> bestStudents = new();

int n = int.Parse(Console.ReadLine());

for (int i = 0; i < n; i++)
{
    string studentName = Console.ReadLine();
    double studentGrade = double.Parse(Console.ReadLine());

    if (!keyValuePairs.ContainsKey(studentName))
    {
        keyValuePairs.Add(studentName, new List<double>());
        keyValuePairs[studentName].Add(studentGrade);
    }

    else
    {
        keyValuePairs[studentName].Add(studentGrade);
    }
}

foreach (var student in keyValuePairs)
{
    int gradeCnt = student.Value.Count;
    double Sum = 0.00;

    for (int i = 0; i < gradeCnt; i++)
    {
        Sum += student.Value[i];
    }

    double averageGrade = Sum / gradeCnt;

    if (averageGrade >= 4.50)
    {
        bestStudents.Add(student.Key, averageGrade);
    }
}

foreach (var otlichnik in bestStudents) 
{
    Console.WriteLine($"{otlichnik.Key} -> {otlichnik.Value:f2}");
}