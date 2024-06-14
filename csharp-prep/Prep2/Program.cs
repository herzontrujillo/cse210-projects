using System;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("C# Activity 2!");
    
        Console.Write("Plese enter your grade percentage: ");
        string userInput = Console.ReadLine();
        int grade = int.Parse(userInput);

        if (grade >= 94)
        {
            Console.WriteLine("A");
        }
       
        else if (grade >= 90 && grade <= 93)
        {
            Console.WriteLine("A-");
        }

        else if (grade >= 87 && grade <= 90)
        {
            Console.WriteLine("B+");
        }

        else if (grade >= 83 && grade <= 87)
        {
            Console.WriteLine("B");
        }
       
        else if (grade >= 80 && grade <= 83)
        {
            Console.WriteLine("B-");
        }
        
        else if (grade >= 77  && grade <= 80)
        {
            Console.WriteLine("C+");
        }

        else if (grade >= 73 && grade <= 77)
        {
            Console.WriteLine("C");
        }
       
        else if (grade >= 70 && grade <= 70)
        {
            Console.WriteLine("C-");
        }
        
         else if (grade >= 67 && grade <= 70)
        {
            Console.WriteLine("D+");
        }

        else if (grade >= 63 && grade <= 67)
        {
            Console.WriteLine("D");
        }
        else if (grade >= 60 && grade <= 63)
        {
            Console.WriteLine("D-");
        }

        else
        {
            Console.WriteLine("F");
        }

        if (grade >= 70)
        {
            Console.WriteLine("Congratulations you passed");
        }

        else
        {
            Console.WriteLine("You did not passed, you will get it next time. Best luck!");
        }
    }
}