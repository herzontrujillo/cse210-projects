using System.IO;
using System.Collections.Generic;
using System;

public class RandomScriptures
{
    private List<Scripture> gospelSripture = new List<Scripture>();
    public void AddingScripture(Reference reference, string text)
    {
        gospelSripture.Add(new Scripture(reference, text));
    }

    public Scripture RandomScripture()
    {
        Random random = new Random();
        int index = random.Next(gospelSripture.Count);
        return gospelSripture[index];
    }

    

       
    

}
