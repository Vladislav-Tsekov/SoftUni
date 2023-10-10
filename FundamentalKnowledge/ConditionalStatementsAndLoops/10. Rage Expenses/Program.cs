


int lostGameCnt = int.Parse(Console.ReadLine());
double headsetPrice = double.Parse(Console.ReadLine());
double mousePrice = double.Parse(Console.ReadLine());
double keyboardPrice = double.Parse(Console.ReadLine());
double displayPrice = double.Parse(Console.ReadLine());

int trashedHeadset = 0;
int trashedMouse = 0;
int trashedKeyboard = 0;
int trashedDisplay = 0;

for (int i = 1; i <= lostGameCnt; i++)
{
	if (i % 2 == 0 && i % 3 == 0)
	{
		trashedHeadset++;
		trashedMouse++;
		trashedKeyboard++;

		if (trashedKeyboard % 2 == 0)
		{
			trashedDisplay++;
		}
		continue;
	}
	if (i % 2 == 0)
	{
		trashedHeadset++;
	}
	else if (i % 3 == 0)
	{
		trashedMouse++;
	}
}

double rageExpense = (headsetPrice * trashedHeadset) + (mousePrice * trashedMouse) + (keyboardPrice * trashedKeyboard) + (displayPrice * trashedDisplay);
Console.WriteLine($"Rage expenses: {rageExpense:f2} lv.");