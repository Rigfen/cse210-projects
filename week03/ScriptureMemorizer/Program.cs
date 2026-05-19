using System;

class Program
{
    static void Main(string[] args)
    {
        Reference reference =
            new Reference("Enos", 1, 9);

        Scripture scripture =
            new Scripture(reference,
            "Now, it came to pass that when I had heard these words I began to feel a desire for the welfare of my brethren, the Nephites; wherefore, I did pour out my whole soul unto God for them.");

        while (!scripture.IsCompletelyHidden())
        {
            Console.Clear();

            Console.WriteLine(scripture.GetDisplayText());

            Console.WriteLine();
            Console.WriteLine("Press enter or type quit");

            string input = Console.ReadLine();

            if (input == "quit")
            {
                break;
            }

            scripture.HideRandomWord();
        }
    }
}