using System;

class Program
{
    static void DisplayMessage()

    {
        Console.WriteLine("Hello World!");
    }

    static void Main(string[] args)
    {
        DisplayMessage();
        PromptUser();
        int result = AddNumbers(5, 7);
        Console.Write($"The sum of the numbers is: {result}");
    }

    static void PromptUser()
    {
        Console.Write("What is your name? ");
        string name= Console.ReadLine();
        Console.WriteLine($"Hello {name}!");
    }

    static int AddNumbers (int num1, int num2)
    {
        int sum = num1 + num2;
        return sum;
    }
}