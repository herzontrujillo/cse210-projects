using System.Diagnostics;
using System.Security.Cryptography.X509Certificates;

public class BreathingActivity : Activity
{
    private string _breathIn = "Breath in.!";
    private string _breathOut = "Breath out.!";
    private string _description = "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.";
    public BreathingActivity(string activityName, int duration)
        : base (activityName, duration);
    
    protected override void PromptBreathing(int index)
    {
        if (index % 2 == 1)
        Console.WriteLine($"{_breathIn}...");

        else 
            Console.WriteLine($"{_breathOut}...");
        
    }

}

