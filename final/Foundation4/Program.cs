using System;

class Program
{
    static void Main(string[] args)
    {
        Activity cycling =  new Bicycling("08 Feb 2024", 33, 15);
        Activity cycling2 =  new Bicycling("12 Feb 2024", 40, 12);
        Activity running =  new Running("10 Mar 2024", 3, 12);
        Activity running2 =  new Running("20 Mar 2024", 5, 10);
        Activity swimming =  new Swimming("04 Aug 2024", 15, 7.5);
        Activity swimming2 =  new Swimming("14 Aug 2024", 20, 12);
        
        // Add element to a new list with "{}" instead of using ".Add"
        List<Activity>  sports = new List<Activity>{cycling,cycling2,running,running2,swimming,swimming2};
        Console.Clear();
         foreach (Activity activity in sports)
         {
            
            Console.WriteLine("************************");
            Console.WriteLine(activity.Summary());
         }




         

    }
}