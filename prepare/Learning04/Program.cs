using System;

class Program
{    static void Main(string[] args)
    {
        // Create a base "Assignment"
        Assignment a1 = new Assignment("Samuel Bennett", "Multiplication");
        Console.WriteLine(a1.GetSumary());
        Console.WriteLine("");

        // Create a derived MathAssignmant class
        MathAssignment a2 = new MathAssignment("Roberto Rodriguez", "Fractions", "7.3", "8-9");
        Console.WriteLine(a2.GetSumary());
        Console.WriteLine(a2.GetHomeWorkList());
        Console.WriteLine("");

        // Create a derived WritinAssignment class
        WritingAssignment a3 = new WritingAssignment("mary Waters", "Euripean History", "The Cause of World War II");
        Console.WriteLine(a3.GetSumary());
        Console.WriteLine(a3.GetWritingInformation());        
    }
}