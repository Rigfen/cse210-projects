using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();

        shapes.Add(new Square("Red", 5));
        shapes.Add(new Rectangle("Blue", 4, 6));
        shapes.Add(new Circle("Green", 3));
        shapes.Add(new Square("Yellow", 7));

        Console.WriteLine("Shapes and Their Areas");
        Console.WriteLine("----------------------");

        foreach (Shape shape in shapes)
        {
            SetConsoleColor(shape.GetColor());

            Console.WriteLine($"Color: {shape.GetColor()}");
            Console.WriteLine($"Area: {shape.GetArea():F2}");
            Console.WriteLine();

            Console.ResetColor();
        }
    }

    static void SetConsoleColor(string color)
    {
        switch (color.ToLower())
        {
            case "red":
                Console.ForegroundColor = ConsoleColor.Red;
                break;

            case "blue":
                Console.ForegroundColor = ConsoleColor.Blue;
                break;

            case "green":
                Console.ForegroundColor = ConsoleColor.Green;
                break;

            case "yellow":
                Console.ForegroundColor = ConsoleColor.Yellow;
                break;

            case "cyan":
                Console.ForegroundColor = ConsoleColor.Cyan;
                break;

            case "magenta":
                Console.ForegroundColor = ConsoleColor.Magenta;
                break;

            default:
                Console.ForegroundColor = ConsoleColor.White;
                break;
        }
    }
}