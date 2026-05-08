using System;

class Program
{
    static void Main(string[] args)
    {
        ShowMessage();

        string name = GetName();

        int number = GetNumber();

        int answer = number * number;

        ShowResult(name, answer);
    }

    static void ShowMessage()
    {
        Console.WriteLine("Welcome!");
    }

    static string GetName()
    {
        Console.Write("What is your name? ");

        string userName = Console.ReadLine();

        return userName;
    }

    static int GetNumber()
    {
        Console.Write("Enter a number: ");

        int userNumber = int.Parse(Console.ReadLine());

        return userNumber;
    }

    static void ShowResult(string name, int result)
    {
        Console.WriteLine($"{name}, your number squared is {result}");
    }
}