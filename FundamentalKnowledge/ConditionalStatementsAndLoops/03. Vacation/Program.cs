

int pplCnt = int.Parse(Console.ReadLine());
string grpType = Console.ReadLine();
string weekDay = Console.ReadLine();

decimal pricePerPerson = 0;

if (grpType == "Students")
{
	if (weekDay == "Friday")
	{
		pricePerPerson += 8.45m;
	}
	else if (weekDay == "Saturday")
	{
		pricePerPerson += 9.80m;
	}
	else if (weekDay == "Sunday")
	{
		pricePerPerson += 10.46m;
	}

    if (pplCnt >= 30)
    {
        pricePerPerson *= 0.85m;
    }

    decimal totalPrice = pricePerPerson * pplCnt;
    Console.WriteLine($"Total price: {totalPrice:F2}");
}
else if (grpType == "Business")
{
    if (weekDay == "Friday")
    {
        pricePerPerson += 10.90m;
    }
    else if (weekDay == "Saturday")
    {
        pricePerPerson += 15.60m;
    }
    else if (weekDay == "Sunday")
    {
        pricePerPerson += 16m;
    }

    if (pplCnt >= 100)
    {
        pplCnt -= 10;
    }

    decimal totalPrice = pricePerPerson * pplCnt;
    Console.WriteLine($"Total price: {totalPrice:f2}");
}
else if (grpType == "Regular")
{
    if (weekDay == "Friday")
    {
        pricePerPerson += 15m;
    }
    else if (weekDay == "Saturday")
    {
        pricePerPerson += 20m;
    }
    else if (weekDay == "Sunday")
    {
        pricePerPerson += 22.50m;
    }

    if (pplCnt >= 10 && pplCnt <= 20)
    {
        pricePerPerson *= 0.95m;
    }

    decimal totalPrice = pricePerPerson * pplCnt;
    Console.WriteLine($"Total price: {totalPrice:f2}");
}
