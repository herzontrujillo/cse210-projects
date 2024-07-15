using System;

class Program
{
    static void Main(string[] args)
    {
        string userInput = "";       
        {
            
            Console.Clear();
            Console.WriteLine("---------------------------------------");
            Console.WriteLine("Welcome to Minfulness Activity!!!");
            Console.WriteLine("1.- Breathing Activity");
            Console.WriteLine("2.- Reflecting Activity");
            Console.WriteLine("3.- Listing Activity");
            Console.WriteLine("4.- Exit");
            Console.WriteLine("");
            Console.WriteLine("---------------------------------------");
            Console.WriteLine("Choose any activity by typing the (1-4)");

            userInput = Console.ReadLine();
            
            while (userInput != "4")
            {
                switch(userInput)
                {
                    case "1":
                        BreathingActivity breathing = new BreathingActivity(1);
                        breathing.StartActivity();
                        breathing.RenderBreathing();
                        breathing.ClosingActivity();
                        break;

                    case "2":
                        ReflectingActivity reflecting = new ReflectingActivity(1);
                        reflecting.StartActivity();
                        reflecting.PromptAndQuestion();
                        reflecting.ClosingActivity();
                        break;

                    case "3":
                        ListingActivity listing = new ListingActivity(1);
                        listing.StartActivity();
                        listing.RenderText();
                        listing.ClosingActivity();
                        break;
                    
                    case "4":
                        Console.WriteLine("Good Bye!!");
                        break;

                    default:
                        Console.WriteLine("Invalid choice, select an option from 1-4");
                        return;     

                }
            }
            Environment.Exit(0);
        }
        
    }
}