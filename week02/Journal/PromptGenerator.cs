using System;
using System.Collections.Generic;

class PromptGenerator
{
    public List<string> _prompts = new List<string>()
    {
        "What was the best part of your day?",
        "Who made you smile today?",
        "What did you learn today?",
        "What are you grateful for?",
        "What was difficult today?"
    };

    public string GetRandomPrompt()
    {
        Random randomGenerator = new Random();

        int number = randomGenerator.Next(_prompts.Count);

        return _prompts[number];
    }
}