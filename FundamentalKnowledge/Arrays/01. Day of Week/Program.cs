
string input = Console.ReadLine();
string[] dayOfWeek = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday", "Invalid day!" };

if (input == "1")
{
    Console.WriteLine(dayOfWeek[0]);
}
else if (input == "2")
{
    Console.WriteLine(dayOfWeek[1]);
}
else if (input == "3")
{
    Console.WriteLine(dayOfWeek[2]);
}
else if (input == "4")
{
    Console.WriteLine(dayOfWeek[3]);
}
else if (input == "5")
{
    Console.WriteLine(dayOfWeek[4]);
}
else if (input == "6")
{
    Console.WriteLine(dayOfWeek[5]);
}
else if (input == "7")
{
    Console.WriteLine(dayOfWeek[6]);
}
else
{
    Console.WriteLine(dayOfWeek[7]);
}