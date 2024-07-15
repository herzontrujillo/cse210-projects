

using System.Diagnostics;

public class ListingActivity : Activity
{
    public ListingActivity(int duration) : base ("Listing","This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.", duration){}

    List<string> _prompts = new List<string>()
    {
        "Who are people that you appreciate?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "What are personal strengths of yours?",
        "Who are some of your personal heroes?"
    };

    public string GetRandomPrompt()
    {
        Random random = new Random();
        int i = random.Next(0,_prompts.Count);
        return _prompts[i]; 
    }

    public void RenderText()
    {
        Console.Clear();
        var _promptQuestion = GetRandomPrompt();
        Console.WriteLine("List as many as you can.");
        Console.WriteLine($"**** {_promptQuestion} ****");
        
        DateTime actualTime = DateTime.Now;
        DateTime futureTime = actualTime.AddSeconds(GetDuration());

    }
}