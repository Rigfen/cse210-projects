using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();

        Console.WriteLine("Enter numbers. Type 0 to finish.");

        while (true)
        {
            Console.Write("Enter a number: ");

            int number = int.Parse(Console.ReadLine());

            if (number == 0)
            {
                break;
            }

            numbers.Add(number);
        }

        int sum = 0;
        int largest = numbers[0];

        foreach (int number in numbers)
        {
            sum += number;

            if (number > largest)
            {
                largest = number;
            }
        }

        double average = (double)sum / numbers.Count;

        Console.WriteLine($"Sum: {sum}");
        Console.WriteLine($"Average: {average}");
        Console.WriteLine($"Largest Number: {largest}");
    }
}