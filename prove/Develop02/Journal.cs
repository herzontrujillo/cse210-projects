using System;
using System.ComponentModel;
using System.IO;
using System.Security.Cryptography.X509Certificates;


public class Journal
{
    public List<Entry> _entries = new List<Entry>();


public void AddEntry()
{
    //Prompt the random prompt
    Entry entry = new Entry();

    PromptGenerator prompt = new PromptGenerator();
    entry._promptText = prompt.GetRandomPrompt();
    Console.WriteLine(entry._promptText);
    entry._entryText = Console.ReadLine();
    //Need to add the date at the top   
    entry._date = DateTime.Now.ToString("MM/dd/yyyy HH:mm");
        
    _entries.Add(entry);
    

}
public void DisplayAll()
{
    
    foreach (Entry entry in _entries)
    {
        Console.WriteLine($">>{entry._date} >Prompt: {entry._promptText},\n >> {entry._entryText}");
        
    }
}


//Save to a Filename 
public void SaveToFile()
{
    Console.WriteLine("What is the file name: ");
    string fileName = Console.ReadLine();
    using (StreamWriter outputFile = new StreamWriter(fileName))
    {
        foreach (Entry entry in _entries)
        outputFile.WriteLine($"{entry._date}^^^{entry._promptText}^^^{entry._entryText}");
    }
    Console.WriteLine($"Your file is save in {fileName} ");
  
}


//Load Data from File 
public void LoadFromFile()
{
    Console.WriteLine("Please enter the filename: ");
    string fileName = Console.ReadLine();
    StreamReader reader = new StreamReader(fileName);
    string lines = "";
    while ((lines = reader.ReadLine()) != null)
    {
        Console.WriteLine(lines);
    }
    reader.Close();
}
public void ClosingMessage()
{
    PromptGenerator closingMessage = new PromptGenerator();
    string message = closingMessage.ClosingMessage();
    Console.WriteLine(message);
}

}