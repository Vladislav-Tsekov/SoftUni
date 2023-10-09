

Dictionary<string, string> database = new Dictionary<string, string>();

int n = int.Parse(Console.ReadLine());

for (int i = 0; i < n; i++)
{
    string command = Console.ReadLine();
    string[] cmdArgs = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);
    string action = cmdArgs[0];
    string username = cmdArgs[1];

    if (action == "register")
    {
        string licensePlateNumber = cmdArgs[2];

        if (database.ContainsKey(username))
        {
            Console.WriteLine($"ERROR: already registered with plate number {licensePlateNumber}");
            continue;
        }

        database.Add(username, licensePlateNumber);
        Console.WriteLine($"{username} registered {licensePlateNumber} successfully");
    }
    else
    {
        if (!database.ContainsKey(username)) 
        {
            Console.WriteLine($"ERROR: user {username} not found");
            continue;
        }

        database.Remove(username);
        Console.WriteLine($"{username} unregistered successfully");
    }
}

foreach (var kvp in database)
{
    Console.WriteLine($"{kvp.Key} => {kvp.Value}");
}

