// Add Systems and Systems.Collections.Generic
using System;
using System.Collections.Generic;

public class PromptGenerator
{
    // Create a list of prompts to display to user
    public List<string> _prompts = new List<string>
    {
        "What was the best thing that happened today?",
        "What did I learn today? How can i apply this to my life in the future?",
        "What could i have done differently today?",
        "How did I show gratitude today?",
        "When was the last time I felt inspired?",
        "How can I cultivate positive influences in my life?"

    };

    public string GetRandomPrompt()
    {
        // Create a random promp from PromtGenerator
        Random random = new Random();
        int i = random.Next(_prompts.Count);
        
        //Return index _prompts
        return _prompts[i];
    }

    public List<string> _closingMessage = new List<string>()
    {
        "Dont forget God loves you.",
        "You are a lovely Human being.",
        "Gos is always with you!",
        "No matter how hard the situation is, you are not alone!"
    };

    public string ClosingMessage()
    {
        Random ranMessage = new Random();
        int i = ranMessage.Next(_closingMessage.Count);

        return _closingMessage[i];
    }


}