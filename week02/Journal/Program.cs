// Added time tracking for entries
// and improving journal formatting when displayed and saved.

using System;

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        journal.LoadFromFile("journal.txt");
        PromptGenerator promptGenerator = new PromptGenerator();

        int choice = 0;

        while (choice != 5)
        {
            Console.WriteLine("Journal Menu");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Save");
            Console.WriteLine("4. Load");
            Console.WriteLine("5. Quit");

            Console.Write("Choose an option: ");

            choice = int.Parse(Console.ReadLine());

            if (choice == 1)
            {
                string prompt = promptGenerator.GetRandomPrompt();

                Console.WriteLine(prompt);
                Console.Write("> ");

                string response = Console.ReadLine();

                Entry newEntry = new Entry();

                newEntry._date = DateTime.Now.ToShortDateString();
                newEntry._time = DateTime.Now.ToShortTimeString();
                newEntry._promptText = prompt;
                newEntry._entryText = response;

                journal.AddEntry(newEntry);
            }

            else if (choice == 2)
            {
                journal.DisplayAll();
            }

            else if (choice == 3)
            {
                journal.SaveToFile("journal.txt");
                Console.WriteLine("Journal saved.");
            }

            else if (choice == 4)
            {
                journal.LoadFromFile("journal.txt");
                Console.WriteLine("Journal loaded.");
}
        }
    }
}