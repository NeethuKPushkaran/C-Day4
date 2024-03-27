using System;

// Interface definition
public interface IShape
{
    double GetArea();
}

// Circle class implementing the Shape interface
public class Circle : IShape
{
    public double Radius { get; set; }

    public Circle(double radius)
    {
        Radius = radius;
    }

    public double GetArea()
    {
        return Math.PI * Math.Pow(Radius, 2);
    }
}

// Rectangle class implementing the Shape interface
public class Rectangle : IShape
{
    public double Length { get; set; }
    public double Width { get; set; }

    public Rectangle(double length, double width)
    {
        Length = length;
        Width = width;
    }

    public double GetArea()
    {
        return Length * Width;
    }
}

// Square class implementing the Shape interface
public class Square : IShape
{
    public double Side { get; set; }

    public Square(double side)
    {
        Side = side;
    }

    public double GetArea()
    {
        return Math.Pow(Side, 2);
    }
}

class Program
{
    static void Main()
    {
        // Creating objects of different shapes
        Circle circle = new Circle(5);
        Rectangle rectangle = new Rectangle(4, 6);
        Square square = new Square(3);

        // Calculating and displaying areas
        Console.WriteLine($"Area of Circle: {circle.GetArea():F2}");
        Console.WriteLine($"Area of Rectangle: {rectangle.GetArea()}");
        Console.WriteLine($"Area of Square: {square.GetArea()}");
    }
}
