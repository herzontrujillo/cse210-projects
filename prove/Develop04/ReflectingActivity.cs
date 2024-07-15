using System;


public class ReflectingActivity : Activity
{

    public ReflectingActivity(int duration) : base("Reflecting", "This activity will help you reflect on times in your life when you have shown strength and resilence. Will show you the power you have and how you can use it in other aspects of your life.", duration){}

    // Create list of prompts and questions
    private List<string> _prompts = new List<string>
    {
        "Think of a time when you faced a difficult personal situation.",
        "Thin of the time you overcame a difficult obstacle",
        "Think of a time when you helped someone in need.",
        "Think of a time when you prioritized the needs of others before you own needs.",
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something truly selfless.",
    };

    private List<string> _questions = new List<string>
    {
        "How did you feel when it was complete?",
        "What is your favorite thing about this experience?",
        "How can you keep this experience in mind in the future?",
        "Have you ever done anything like this before?",
        "What was your motivation?",
    };

    
    public string RandomPromt()
    {
        Random random = new Random();
        int i = random.Next(0, _prompts.Count);
        return _prompts[i];
    }

    public string RandomQuestion()
    {
        Random random = new Random();
        int i = random.Next(0, _questions.Count);
        return _questions[i];
    }

    // Render Random Prompt and Random Question at the end of the timer

    public void PromptAndQuestion()
    {
        var prompt = RandomPromt();

        Console.WriteLine("Mull over the next Prompt.");
        Console.WriteLine($"**** {prompt} ****");
        Console.Write("Press Enter to continue.");

        var userInput = Console.ReadKey();
        if (userInput.Key == ConsoleKey.Enter)
        {
            DateTime actualTime = DateTime.Now;
            DateTime futureTime = actualTime.AddSeconds(GetDuration());
            
            while (actualTime <= futureTime)
            {
                var question = RandomQuestion();
                Console.WriteLine($"{question} ' '");
                // Spinner(10);
                Console.WriteLine();
                break;

            }
        }
    }
}



