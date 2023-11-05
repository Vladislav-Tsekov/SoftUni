
//C:\Internal\training-internal\Template.pptx

string input = Console.ReadLine();

int firstSymbol = input.LastIndexOf(@"\") + 1;
int lastSymbol = input.LastIndexOf(".");
int length = lastSymbol - firstSymbol;

string fileName = input.Substring(firstSymbol, length);
string fileExtension = input.Substring(lastSymbol + 1);


Console.WriteLine($"File name: {fileName}");
Console.WriteLine($"File extension: {fileExtension}");
