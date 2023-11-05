


using static System.Net.Mime.MediaTypeNames;

string input = string.Empty;

while ((input = Console.ReadLine()) != "end")
{
    char[] cArray = input.ToCharArray();
    string reverse = string.Empty;

    for (int i = cArray.Length - 1; i > -1; i--)
    {
        reverse += cArray[i];
    }

    Console.WriteLine($"{input} = {reverse}");
}


