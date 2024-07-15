using System.Diagnostics;
using System.Security.Cryptography.X509Certificates;
using Microsoft.VisualBasic;

public class BreathingActivity : Activity
{
    int timerPos = 2;
    public BreathingActivity(int duration) : base("Breathing","This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.",duration){}
    
    private string _breathIn = "Breath in....!";
    private string _breathOut = "Breath out....!";
   
    public void RenderBreathing()
    {
        var currentTime = DateTime.Now;
        var endTime = DateTime.Now.AddSeconds(GetDuration());
        while (currentTime <= endTime)
        {   Console.WriteLine("");
            Console.Write(_breathIn);
            Timer(4);
            Console.Write(_breathOut);
            Timer(7);
            currentTime = DateTime.Now;
        } 
    }
    public void Timer(int seconds)
    {
        timerPos = Console.CursorLeft;
        for (int i=0; i <= seconds; i++)
        {
            Console.CursorLeft = timerPos;
            Console.WriteLine();
            Console.WriteLine(seconds -i);
            Thread.Sleep(500);
        }
        Console.WriteLine("");
        Console.CursorLeft = timerPos;
        Console.WriteLine("");
        
    }
}

