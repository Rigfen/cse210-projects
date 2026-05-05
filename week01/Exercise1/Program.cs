using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise1 Project.");
        Console.WriteLine("I am learning how to use Visual Studio Code and GitHub.");

        int number = 5;
        number = number + 10;
        number = 9 * number;


        Console.Write("what is your first name? " );
        string name = Console.ReadLine();

        Console.Write("What is your last name? ");
        string lastname = Console.ReadLine();

        Console.WriteLine($"Hello, {lastname}, {name}! Welcome to C# programming!");
    
    }
}