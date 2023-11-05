

string input = Console.ReadLine(); //Agd#53Dfg^&4F53

foreach (char ch in input) {
    if (char.IsDigit(ch)) {
        Console.Write(ch);
    }
}
Console.WriteLine();
foreach (char ch in input) {
	if (char.IsLetter(ch)) {
        Console.Write(ch);
    }
}
Console.WriteLine();
foreach (char ch in input) {
    if (!char.IsLetterOrDigit(ch)) {
        Console.Write(ch);
    }
}

