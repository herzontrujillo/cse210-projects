using System;

class Program
{
    static void Main(string[] args)
    {

        // LECTURE EVENT


        Location Lectures = new Location("917 Hullen Dr", "Downey", "CA", "Usa.");
        Lecture lecture = new Lecture("C# Tutorial-Basics", "Introduction to Abstraction, Encapsulation, Iheritance, Polymorphism", "July 22, 2024.", "18:00 Hrs.", Lectures, "Mosh More", 100);

        Console.WriteLine();
        Console.WriteLine("⇢⇢⇢⇢⇢⇢⇢⇢⇢⇢⇢⇢ Event Sumarize. ⇠⇠⇠⇠⇠⇠⇠⇠⇠⇠⇠⇠");
        Console.WriteLine("➖➖➖➖➖➖➖➖➖➖➖➖➖➖➖➖➖➖➖➖➖➖➖➖➖➖");
        Console.WriteLine(lecture.SumaryDetail());
        Console.WriteLine("⇢⇢⇢⇢⇢⇢⇢⇢⇢⇢⇢⇢ Event Standar Details. ⇠⇠⇠⇠⇠⇠⇠⇠⇠⇠⇠⇠");
        Console.WriteLine("➖➖➖➖➖➖➖➖➖➖➖➖➖➖➖➖➖➖➖➖➖➖➖➖➖➖");
        Console.WriteLine(lecture.StandarDetail());
        Console.WriteLine("⇢⇢⇢⇢⇢⇢⇢⇢⇢⇢⇢⇢ Event Full Details. ⇠⇠⇠⇠⇠⇠⇠⇠⇠⇠⇠⇠");
        Console.WriteLine("➖➖➖➖➖➖➖➖➖➖➖➖➖➖➖➖➖➖➖➖➖➖➖➖➖➖");
        Console.WriteLine(lecture.RenderFullDetail());
        Console.WriteLine("❖❖❖❖❖❖❖❖❖❖❖❖❖❖❖❖❖❖❖❖❖❖❖❖❖❖❖❖❖❖❖❖❖❖❖❖❖❖❖❖❖❖❖❖❖❖");

        // OUTDOOR EVENT 

        Location OutdoorEvent = new Location("At&t Stadium", "Arlington", "TX", "Usa.");
        Outdoor outdoorEvent = new Outdoor("Pink Floyd-Final Tour", "Final Tour Concert of Pink Floy", "October 16, 2024", "17:00 Hrs", OutdoorEvent, "Clear Skies");

        Console.WriteLine();
        Console.WriteLine("⇢⇢⇢⇢⇢⇢⇢⇢⇢⇢⇢⇢ Event Sumarize. ⇠⇠⇠⇠⇠⇠⇠⇠⇠⇠⇠⇠");
        Console.WriteLine("➖➖➖➖➖➖➖➖➖➖➖➖➖➖➖➖➖➖➖➖➖➖➖➖➖➖");
        Console.WriteLine(outdoorEvent.SumaryDetail());
        Console.WriteLine("⇢⇢⇢⇢⇢⇢⇢⇢⇢⇢⇢⇢ Event Standar Details. ⇠⇠⇠⇠⇠⇠⇠⇠⇠⇠⇠⇠");
        Console.WriteLine("➖➖➖➖➖➖➖➖➖➖➖➖➖➖➖➖➖➖➖➖➖➖➖➖➖➖");
        Console.WriteLine(outdoorEvent.StandarDetail());
        Console.WriteLine("⇢⇢⇢⇢⇢⇢⇢⇢⇢⇢⇢⇢ Event Full Details. ⇠⇠⇠⇠⇠⇠⇠⇠⇠⇠⇠⇠");
        Console.WriteLine("➖➖➖➖➖➖➖➖➖➖➖➖➖➖➖➖➖➖➖➖➖➖➖➖➖➖");
        Console.WriteLine(outdoorEvent.RenderFullDetail());
        Console.WriteLine("❖❖❖❖❖❖❖❖❖❖❖❖❖❖❖❖❖❖❖❖❖❖❖❖❖❖❖❖❖❖❖❖❖❖❖❖❖❖❖❖❖❖❖❖❖❖");


        // RECEPTION EVENT

        Location ReceptionEvent = new Location("8291 Crysta Ct", "Tulsa", "OK", "Usa.");
        Reception reception = new Reception("Blue's FareWell", "Join us to say goodbye to Blue before her trip to Europe", "Saturday May 1st", "01:00 PM.", ReceptionEvent,"RSVP");

        Console.WriteLine();
        Console.WriteLine("⇢⇢⇢⇢⇢⇢⇢⇢⇢⇢⇢⇢ Event Sumarize. ⇠⇠⇠⇠⇠⇠⇠⇠⇠⇠⇠⇠");
        Console.WriteLine("➖➖➖➖➖➖➖➖➖➖➖➖➖➖➖➖➖➖➖➖➖➖➖➖➖➖");
        Console.WriteLine(reception.SumaryDetail());
        Console.WriteLine("⇢⇢⇢⇢⇢⇢⇢⇢⇢⇢⇢⇢ Event Standar Details. ⇠⇠⇠⇠⇠⇠⇠⇠⇠⇠⇠⇠");
        Console.WriteLine("➖➖➖➖➖➖➖➖➖➖➖➖➖➖➖➖➖➖➖➖➖➖➖➖➖➖");
        Console.WriteLine(reception.StandarDetail());
        Console.WriteLine("⇢⇢⇢⇢⇢⇢⇢⇢⇢⇢⇢⇢ Event Full Details. ⇠⇠⇠⇠⇠⇠⇠⇠⇠⇠⇠⇠");
        Console.WriteLine("➖➖➖➖➖➖➖➖➖➖➖➖➖➖➖➖➖➖➖➖➖➖➖➖➖➖");
        Console.WriteLine(reception.RenderFullDetail());
        Console.WriteLine("❖❖❖❖❖❖❖❖❖❖❖❖❖❖❖❖❖❖❖❖❖❖❖❖❖❖❖❖❖❖❖❖❖❖❖❖❖❖❖❖❖❖❖❖❖❖");

    }
}