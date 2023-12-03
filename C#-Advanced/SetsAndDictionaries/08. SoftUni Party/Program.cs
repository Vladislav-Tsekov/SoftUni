
HashSet<string> guestList = new();
HashSet<string> vipGuestList = new();

string entryName = string.Empty;
while ((entryName = Console.ReadLine()) != "PARTY")
{
    bool isDigit = char.IsDigit(entryName[0]);

    if (isDigit)
        vipGuestList.Add(entryName);
    else
        guestList.Add(entryName);
}

string guestsThatCame = string.Empty;
while ((guestsThatCame = Console.ReadLine()) != "END")
{
    bool isDigit = char.IsDigit(guestsThatCame[0]);

    if (isDigit)
        vipGuestList.Remove(guestsThatCame);
    else
        guestList.Remove(guestsThatCame);
}

int listSize = guestList.Count + vipGuestList.Count;
Console.WriteLine(listSize);

foreach (string vipGuest in vipGuestList)
    Console.WriteLine(vipGuest);

foreach (string guest in guestList)
    Console.WriteLine(guest); 