using System;

class Program
{
    static void Main(string[] args)
    {

       Random randomGenerator = new Random();
int number = randomGenerator.Next(1, 100);

int guess = -1;

while (guess != number)
{
    Console.Write("What is your guess? ");
    guess = int.Parse(Console.ReadLine());

    if (guess < number)
            {
                Console.WriteLine("Too Low Try again!");
            }
            else if (guess > number)
            {
                Console.WriteLine("Too High Try Again");

            }
            else
            {
                Console.WriteLine("You Got it!");
            }

}

Console.WriteLine($"The random number is: {number}");
}}