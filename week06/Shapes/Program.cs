using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Shapes Project.");

        List<Shape> shapes = new List<Shape>();

        Square square = new Square("Red", 3);
        shapes.Add(square);

        Rectangle rectangle = new Rectangle("Green", 8.5, 5);
        shapes.Add(rectangle);

        Circle circle = new Circle("Yellow", 3.5);
        shapes.Add(circle);

        foreach (Shape shape in shapes)
        {
            Console.WriteLine(shape.GetColor());
            Console.WriteLine(shape.GetArea());
        }
    }
}