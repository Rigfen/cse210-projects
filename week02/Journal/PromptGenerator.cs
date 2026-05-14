using System;

class PromptGenerator
{
    public List<string> _prompts = new List<string>()
    {

        "What was the best part of your day?",
        "What are you grateful for today?", 
        "What is something you learned today?",
        "What is a goal you have for tomorrow?",
        "What is something that made you smile today?",
        "What are you grateful for?"

    };


    public string GetRandomPrompt()

    {
        Random random = new Random();

int number = random.Next(_prompts.Count);

        return _prompts[number];

    }


}