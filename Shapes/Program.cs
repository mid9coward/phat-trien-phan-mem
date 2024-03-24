using System;

class Program
{
    static void Main(string[] args)
    {
        Circle circle = new Circle(5);
        Console.WriteLine("Area of Circle: " + circle.CalculateArea());

        Rectangle rectangle = new Rectangle(4, 6);
        Console.WriteLine("Area of Rectangle: " + rectangle.CalculateArea());

        Triangle triangle = new Triangle(3, 7);
        Console.WriteLine("Area of Triangle: " + triangle.CalculateArea());
    }
}

