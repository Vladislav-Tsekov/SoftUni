﻿

using DefiningClasses;
using System.Security.Cryptography.X509Certificates;

public class Person
{
	private string name;
	private int age;
    public string Name
    {
        get { return name; }
        set { name = value; }
    }
    public int Age
	{
		get { return age; }
		set { age = value; }
	}

    public Person(string name, int age) 
    {
        Name = name;
        Age = age;
    }
}