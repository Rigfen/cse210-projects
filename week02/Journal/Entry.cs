using System;

class Entry
{
   public string _date;
    public string _prompttext;
    public string _entrytext;
    public void Display()
    {
        Console.WriteLine($"Date: {_date}- {_prompttext}");
        Console.WriteLine(_entrytext);
        Console.WriteLine();
    }
}