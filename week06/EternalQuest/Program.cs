GoalManager manager = new GoalManager();

bool running = true;

while (running)
{
    Console.Clear();

    manager.DisplayScore();

    Console.WriteLine();
    Console.WriteLine("1. Create Goal");
    Console.WriteLine("2. List Goals");
    Console.WriteLine("3. Record Event");
    Console.WriteLine("4. Save Goals");
    Console.WriteLine("5. Load Goals");
    Console.WriteLine("6. Quit");

    Console.Write("Choice: ");

    string choice = Console.ReadLine();

    if (choice == "1")
    {
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");

        string type = Console.ReadLine();

        Console.Write("Name: ");
        string name = Console.ReadLine();

        Console.Write("Description: ");
        string description = Console.ReadLine();

        Console.Write("Points: ");
        int points = int.Parse(Console.ReadLine());

        if (type == "1")
        {
            manager.AddGoal(
                new SimpleGoal(name, description, points));
        }
        else if (type == "2")
        {
            manager.AddGoal(
                new EternalGoal(name, description, points));
        }
        else if (type == "3")
        {
            Console.Write("Target amount: ");
            int target = int.Parse(Console.ReadLine());

            Console.Write("Bonus points: ");
            int bonus = int.Parse(Console.ReadLine());

            manager.AddGoal(
                new ChecklistGoal(
                    name,
                    description,
                    points,
                    target,
                    bonus));
        }
    }
    else if (choice == "2")
    {
        manager.DisplayGoals();
        Console.ReadKey();
    }
    else if (choice == "3")
    {
        manager.RecordGoal();
        Console.ReadKey();
    }
    else if (choice == "4")
    {
        manager.SaveGoals();
    }
    else if (choice == "5")
    {
        manager.LoadGoals();
    }
    else if (choice == "6")
    {
        running = false;
    }
}