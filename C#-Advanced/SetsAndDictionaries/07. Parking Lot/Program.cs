

HashSet<string> carNumbers = new HashSet<string>();

string carInfo = Console.ReadLine();

while (true)
{
    string[] carInfoArgs = carInfo.Split(", ");
    string direction = carInfoArgs[0];

    if (direction == "END")
    {
        break;
    }
    else if (direction == "IN")
    {
        carNumbers.Add(carInfoArgs[1]);
    }
    else if (direction == "OUT")
    {
        carNumbers.Remove(carInfoArgs[1]);
    }

    carInfo = Console.ReadLine();
}

if (!carNumbers.Any())
{
    Console.WriteLine("Parking Lot is Empty");
}
foreach (var plateNr in carNumbers)
{
    Console.WriteLine(plateNr);
}