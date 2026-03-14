using System;

public class Entry
{
    public string _date;
    public string _promptText;
    public string _entryText;

    public string _mood;

    public void Display()
    {
        Console.WriteLine($"{_date} | Mood: {_mood}");
        Console.WriteLine($"{_promptText}");
        Console.WriteLine($"{_entryText}");
        Console.WriteLine();
    }
}
