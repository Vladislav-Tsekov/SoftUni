
using System.Linq;


string username = Console.ReadLine();
char[] password = username.ToCharArray();
Array.Reverse(password);
string validPass = new string(password);
int loginAttempts = 1;
string passTries = Console.ReadLine();

while (loginAttempts <= 4)
{
	if (passTries == validPass)
	{
		Console.WriteLine($"User {username} logged in.");
        loginAttempts++;
        return;	
	}
	else if (passTries != validPass)
	{
        if (loginAttempts == 4)
        {
            Console.WriteLine($"User {username} blocked!");
			return;
        }
        Console.WriteLine("Incorrect password. Try again.");
		loginAttempts++;
	}
	passTries = Console.ReadLine();
}