

//    • Read the input.
    //• Replace all ban words in the text with an asterisk ('*').
    //    ◦ Use the built-in method Replace(banWord, replacement).
    //    ◦ Use a new string(char ch, int repeatCount) to create the replacement

string[] bannedWords = Console.ReadLine().Split(", ").ToArray();

string text = Console.ReadLine();

foreach (var bannedWord in bannedWords)
{
    text = text.Replace(bannedWord, new string ('*', bannedWord.Length));
}
Console.WriteLine(text);

