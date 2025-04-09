using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();

        Square s1 = new Square("green", 4);
        Rectangle s2 = new Rectangle("blue", 2, 4);
        Circle s3 = new Circle("red", 6);

        shapes.Add(s1);
        shapes.Add(s2);
        shapes.Add(s3);

        foreach (Shape s in shapes) 
        {
            string color = s.GetColor();

            double area = s.GetArea();

            Console.WriteLine($"The {color} shape has an area of {area}.");

        }
    }
}