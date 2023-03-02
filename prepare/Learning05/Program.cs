using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();
        shapes.Add(new Square(2, "red"));
        shapes.Add(new Rectangle(4, 2, "yellow"));
        shapes.Add(new Circle(2, "blue"));

        foreach(Shape shape in shapes)
        {  string color = shape.GetColor();
           double area = shape.GetArea();
           Console.WriteLine($"{area}, {color}");
        }
    }
}