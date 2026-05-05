using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("please enter your grade: ");
        string valueFromUser = Console.ReadLine();
        int percent = int.Parse(valueFromUser);

        string letter = "";

        if ( percent >= 90)
        {
            letter = "A";
        }
         else if (percent >= 80)
        {
            letter = "B";
        }
         else if (percent >= 70)
        {
            letter = "C";
        }
         else if (percent >= 60)
        {
            letter = "D";
        }
         else
        {
            letter = "F";
        }

        Console.WriteLine($"Your grade is: {letter}");

        if(percent >= 70)
        {
            Console.WriteLine("Congratulations! You passed the class!");
        }
         else
        {
            Console.WriteLine("Sorry, you did not pass the class. Better luck next time!");
        }
    

        
    }
}