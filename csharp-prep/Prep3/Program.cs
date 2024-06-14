using System;
using System.Security.Cryptography;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("C# Activity 3!");

        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1, 101);

       int guess = -1;
       int attempts = 0;
       
       
        
        // Create a while loop to run untill user gets the correct number
        while (guess != number)
        { 
            Console.Write("What is your guess? ");
            string userInput = Console.ReadLine();
            guess = int.Parse(userInput);

            if (number > guess)
            {
                Console.WriteLine("Choose a higher number");
                attempts ++;
            }

            else if (number < guess)
            {
                Console.WriteLine("Choose a lower number");
                attempts ++;
            }

            else
            {
                Console.WriteLine($"You have gessed the number in {attempts} attempts."); 
                Console.Write("Would you like to play again? Type Y to continue or N to exit: ");
                string answer = Console.ReadLine().ToUpper();

                if (answer == "N")   
                Console.WriteLine("Thank you for Playing, Good bye!");

                if (answer == "Y")
                return;
            }   
        }   
    }
}