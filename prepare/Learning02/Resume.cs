
using System;

// Need to create a new list named Jobs
// Public Display "void"
public class Resume
{
    public string _name;
    public List<Job> _jobs = new List<Job>();
   
    public void Display()
    {
        Console.WriteLine($"Name: {_name} ");
        Console.WriteLine($"Jobs: ");

        // Create a loop for jobs and Display (method) jobs
        foreach (Job job in _jobs)
        {
            job.Dysplay();
        }

    }
}



