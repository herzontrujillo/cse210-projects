using System;
using System.Diagnostics.CodeAnalysis;
using System.Security.AccessControl;

class Program
{
    static void Main(string[] args)
    {
        
        Console.WriteLine("C# Activity 4!");

        List<int> numbers = new List<int>();
        int choice = -1;

        while (choice != 0)
        {
            Console.Write("Plese type any number or 0 to quit: ");
            string userChoice = Console.ReadLine();
            choice = int.Parse(userChoice);

            if (choice !=0)
            {
                //Add the user choice numbers to the list
                numbers.Add(choice);
            }
            
        }

            //Adding the numbers
        int addition = 0;
        foreach (int number in numbers)
        {
            addition += number;
        }
            //Print the total
        Console.WriteLine($"The sum of the numbers is: {addition}");

                // Compute the average
        float average = ((float)addition) / numbers.Count;
            // Print out the average
        Console.WriteLine($"{average} is the average");

                    //Find the largest
            //create the max variable
        int max = numbers[0];
        
        foreach (int number in numbers)
        {
            // get the max with an if statement
            if (number > max)
            {
                max = number;
            }
        }

            //Print out the max number 
        Console.WriteLine($"The largest is: {max}");
        
    }       
}