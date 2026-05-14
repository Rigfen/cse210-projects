using System;

class Entry
{
   public string _date;
    public string _prompttext;
    public string _entrytext;

    public string _time;
    public void Display()
    {
        Console.WriteLine($"Date/Time:{_date}-{_time}- {_prompttext} ");
        Console.WriteLine(_entrytext);
        Console.WriteLine();
    }
}