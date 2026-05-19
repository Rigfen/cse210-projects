using System;
using System.Collections.Generic;

class Scripture
{
    private Reference _reference;
    private List<Word> _words = new List<Word>();

    public Scripture(Reference reference, string text)
    {
        _reference = reference;

        string[] parts = text.Split(" ");

        foreach (string part in parts)
        {
            _words.Add(new Word(part));
        }
    }

  public void HideRandomWord()
{
    Random random = new Random();

    List<Word> visibleWords = new List<Word>();

    foreach (Word word in _words)
    {
        if (!word.IsHidden())
        {
            visibleWords.Add(word);
        }
    }

    if (visibleWords.Count > 0)
    {
        int index = random.Next(visibleWords.Count);

        visibleWords[index].Hide();
    }
}

    public string GetDisplayText()
    {
        string text = "";

        foreach (Word word in _words)
        {
            text += word.GetDisplayText() + " ";
        }

        return _reference.GetDisplayText() + " " + text;
    }

    public bool IsCompletelyHidden()
    {
        foreach (Word word in _words)
        {
            if (!word.IsHidden())
            {
                return false;
            }
        }

        return true;
    }
}