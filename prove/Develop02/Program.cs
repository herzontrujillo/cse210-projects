using System;
using System.Collections.Generic;
using System.Net;
//using System.Runtime.CompilerServices;

public class Program
{


    static void Main(string[] args)
    {
        Entry userEntry = new Entry();
        Journal journal = new Journal();
        
        while (true)
        {
            

            Console.WriteLine("Wellcome to your Journal");
            Console.WriteLine("Please choose one of the following");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");

            string userChoice = Console.ReadLine();

            // use "switch" to call the objects by selection 

            switch (userChoice)
            {
                // Option #1 Write
                case "1":
                journal.AddEntry();
                break;

                //Option #2 Display 
                case "2":
                journal.DisplayAll();
                break;
                       
                // Option #3 Load from a file
                case "3":
                journal.LoadFromFile();
                break;

                //Ooption #4 Save to a file              
                case "4":
                journal.SaveToFile();
                break;

                // Option #5 exit            
                case "5":
               journal.ClosingMessage();
                return;

                default:
                Console.WriteLine("Invalid input, try again");
                break;
            }
        } 
        
    }
}
