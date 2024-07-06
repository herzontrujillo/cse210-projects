using System;
using System.Dynamic;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks.Dataflow;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Wellcome to the fraction Program");
        Fraction fraction1 = new Fraction();
        Console.WriteLine(fraction1.GetDecimalValue());
        Console.WriteLine(fraction1.GetFractionString());

        Fraction fraction2 = new Fraction(5);
        Console.WriteLine(fraction2.GetDecimalValue());
        Console.WriteLine(fraction2.GetFractionString());
        
        Fraction fraction3 = new Fraction(3, 4);
        Console.WriteLine(fraction3.GetDecimalValue());
        Console.WriteLine(fraction3.GetFractionString());
        
        Fraction fraction4 = new Fraction(1, 3);
        Console.WriteLine(fraction4.GetDecimalValue());
        Console.WriteLine(fraction4.GetFractionString());

    }
}