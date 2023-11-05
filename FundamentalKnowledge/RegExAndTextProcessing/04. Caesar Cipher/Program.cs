

//Programming is cool!

string input = Console.ReadLine();
char[] encryptedText = new char[input.Length];

for (int i = 0; i < input.Length; i++)
{
    encryptedText[i] = (char)(input[i] + 3);
}
Console.WriteLine(encryptedText);
