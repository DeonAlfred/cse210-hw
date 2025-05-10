using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your first name?");
        string name = Console.ReadLine();
        Console.Write("What is your Last name?");
        string Lastname = Console.ReadLine();
        Console.Write($"Your  name is {Lastname}, {name} {Lastname}.");
    }
}