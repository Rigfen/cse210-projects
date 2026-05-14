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
entry._time = DateTime.Now.ToShortTimeString();
entry._prompttext = prompt;
entry._entrytext = response;
Journal journal = new Journal();
journal.ADDEntry(entry);
journal.DisplayAll();
journal.SaveToFile($"C:\\Users\\Rigfe\\OneDrive\\Desktop\\Pathway program\\CSE 210\\cse210-projects\\week02\\Journal\\journal.txt");

    }
}

//I added the time to the entry and display. I also added a save to file and load from file function to the journal class. I also added a file name to the save to file function.