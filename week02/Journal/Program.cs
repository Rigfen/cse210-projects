using System;

class Program
{
    static void Main(string[] args)
    {
       PromptGenerator promptGenerator = new PromptGenerator();
       string prompt = promptGenerator.GetRandomPrompt();

       Console.WriteLine(prompt);
       Console.Write("> ");

string response = Console.ReadLine();

Entry entry = new Entry();
entry._date = DateTime.Now.ToShortDateString();
entry._prompttext = prompt;
entry._entrytext = response;
Journal journal = new Journal();
journal.ADDEntry(entry);
journal.DisplayAll();
journal.SaveToFile("journal.txt");

    }
}