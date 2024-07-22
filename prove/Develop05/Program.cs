using System;
using System.Drawing;
using System.Runtime.Serialization.Formatters;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        
        

        while(true)
        {
            Console.WriteLine("Please selec one of the following options by typing the number: ");
            Console.WriteLine("1. New Goal");
            Console.WriteLine("2. List of Goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record this Event");
            Console.WriteLine("6. Exit");

            string choice = "";
        
            choice = Console.ReadLine();
            GoalManager goalManager = new GoalManager();

            switch (choice)
            {
                case "1":
                    Console.WriteLine("The type of Goals are:");
                    Console.WriteLine("");
                    Console.WriteLine("1.- Simple Goal. \n2.- Eternal Goal. \n3.- Checklist Goal");
                    Console.Write("Which Goal woul you like to create? ");
                    string goalChoice = Console.ReadLine();
                    
                    switch (goalChoice)
                    {
                        case "1":
                            SimpleGoal simple = new SimpleGoal();
                            simple.CreateNewGoal();
                            goalManager.AddingGoal(simple);
                            break;
                        
                        case "2":
                            EternalGoal eternal = new EternalGoal();
                            eternal.CreateNewGoal();
                            goalManager.AddingGoal(eternal);
                            break;

                        case "3":
                            CheckupList checkup = new CheckupList();
                            checkup.CreateNewGoal();
                            goalManager.AddingGoal(checkup);
                            break;
                        default:
                            Console.WriteLine("\nSorry that is not a valid option!");
                            break;
                    }
                    break;      

                case "2":
                    goalManager.ListGoals();
                    break;

                case "3":
                    goalManager.SaveGoals();
                    break;
                
                case "4":
                    goalManager.LoadGoal();
                    break;
                
                case "5":
                    goalManager.RecordEvents();
                    return;
                
                case "6":
                    int exitCode = 0;
                    Environment.Exit(exitCode);
                    break;
            }
        }                    
    }
}