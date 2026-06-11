using System;
using System.Collections.Generic;
using System.IO;

public class GoalManager
{
    private List<Goal> _goals = new List<Goal>();
    private int _score = 0;

    public void DisplayScore()
    {
        Console.WriteLine($"You have {_score} points.");
    }

  public void AddGoal(Goal goal)
{
    _goals.Add(goal);

    Console.WriteLine();
    Console.WriteLine("Goal saved successfully!");
    Console.WriteLine($"You added: {goal.GetName()}");
}

    public void DisplayGoals()
    {
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetStatus()}");
        }
    }

    public void RecordGoal()
    {
        DisplayGoals();

        Console.Write("Which goal did you accomplish? ");
        int choice = int.Parse(Console.ReadLine());

        int earned = _goals[choice - 1].RecordEvent();

        _score += earned;

        Console.WriteLine($"You earned {earned} points!");
    }

    public void SaveGoals()
    {
        Console.Write("Filename: ");
        string fileName = Console.ReadLine();

        using (StreamWriter output = new StreamWriter(fileName))
        {
            output.WriteLine(_score);

            foreach (Goal goal in _goals)
            {
                output.WriteLine(goal.GetStringRepresentation());
            }
        }
    }

    public void LoadGoals()
    {
        Console.Write("Filename: ");
        string fileName = Console.ReadLine();

        string[] lines = File.ReadAllLines(fileName);

        _score = int.Parse(lines[0]);

        _goals.Clear();

        for (int i = 1; i < lines.Length; i++)
        {
            string[] parts = lines[i].Split('|');

            if (parts[0] == "SimpleGoal")
            {
                SimpleGoal goal =
                    new SimpleGoal(parts[1], parts[2], int.Parse(parts[3]));

                goal.SetComplete(bool.Parse(parts[4]));

                _goals.Add(goal);
            }
        }
    }
    
}