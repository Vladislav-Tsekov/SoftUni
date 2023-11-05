

int n = int.Parse(Console.ReadLine());

for (int i = 0; i < n; i++)
{
    string text = Console.ReadLine();

    int nameLength = (text.IndexOf('|') - 1) - text.IndexOf('@');
    string name = text.Substring(text.IndexOf('@') + 1, nameLength);

    int ageLength = (text.IndexOf('*') - 1) - text.IndexOf('#');
    string age = text.Substring(text.IndexOf('#') + 1, ageLength);

    Console.WriteLine($"{name} is {age} years old.");
}