using System;

class Entry
{
    public string _date;
    public string _time;
    public string _promptText;
    public string _entryText;

    public void Display()
    {
        Console.WriteLine($"Date/Time: {_date} {_time}");
        Console.WriteLine($"Prompt: {_promptText}");
        Console.WriteLine($"Entry: {_entryText}");
        Console.WriteLine();
    }
}