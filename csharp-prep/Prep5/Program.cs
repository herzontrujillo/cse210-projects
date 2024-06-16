using System;
using System.Runtime.InteropServices.Marshalling;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("C# Activity 5!");     
        
        // Call the function 
        WelcomeMesagge();
        //Create a variable 
        string Name = UserName();
        int Number = UserNumber();
        int Square = SquareNumber(Number);

        DisplayResult(Name, Square);
    }

    static void WelcomeMesagge()
    {
        Console.WriteLine("Welcome to the program!");
    }

    static string UserName()
    {
        Console.Write("Please type your name: ");
        string name =  Console.ReadLine();
        return name;
    }

    static int UserNumber()
    {
        Console.Write("What is your favorite number? ");
        int number = int.Parse (Console.ReadLine());
        return number;
    }

    static int SquareNumber(int number)
    {
        int square = number * number;
        return square;
    }

    static void DisplayResult(string name, int square)
    {
        Console.WriteLine($"{name}, the square of your number is {square}");
    }

}