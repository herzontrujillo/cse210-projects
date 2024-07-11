using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();

        Square s1 = new Square("Blue", 4);
        shapes.Add(s1);

        Rectangle r1 = new Rectangle("Red", 4, 2);
        shapes.Add(r1);

        Circle c1 = new Circle("Yellow", 4);
        shapes.Add(c1);

        foreach (Shape i in shapes)
        {
            double area = i.GetArea();
            string color = i.GetColor();

            Console.WriteLine($"The shape has a color {color} an area of {area}");
        }
    }
}