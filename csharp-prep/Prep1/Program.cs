using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("C# Activity 2!");
        Console.Write("What is your first name?");
        string first = Console.ReadLine();
        Console.Write("What is your last name?");
        string last = Console.ReadLine();
        Console.WriteLine($"your name is {last}, {first} {last}.");
    }
}