using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();

        Square square = new Square("green", 3);
        Rectangle rectangle = new Rectangle("blue", 4, 5); 
        Circle cirlce = new Circle("red", 6);

        shapes.Add(square);
        shapes.Add(rectangle);
        shapes.Add(cirlce);

        foreach (Shape shape in shapes)
        {
            Console.WriteLine($"The {shape.GetColor()} shape has an area of {shape.GetArea()}");
        }
        
    }
}