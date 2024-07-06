using System;
using System.Dynamic;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        public class Fraction
        {
            private int _top;
            private int _bottom;

            // Create constructo that has no parameters initialize it with 1/1
            public Fraction()
            {
                _top = 1; 
                _bottom = 1;                
            }

            public Fraction(int wholeNumber)
            {
                _top = wholeNumber;
                _bottom = 1;
            }

            public Fraction(int top, int bottom)
            {
                _top = top;
                _bottom = bottom;               
            }
            public GetDecimalValue ()
            {

                return (double)_top / (double)_bottom;
            }
        }


    }
}