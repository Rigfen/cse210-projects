public class ChecklistGoal : Goal
{
    private int _amountCompleted;
    private int _targetAmount;
    private int _bonus;

    public ChecklistGoal(
        string name,
        string description,
        int points,
        int targetAmount,
        int bonus)
        : base(name, description, points)
    {
        _targetAmount = targetAmount;
        _bonus = bonus;
        _amountCompleted = 0;
    }

    public override int RecordEvent()
    {
        _amountCompleted++;

        int earned = GetPoints();

        if (_amountCompleted == _targetAmount)
        {
            earned += _bonus;
        }

        return earned;
    }

    public override bool IsComplete()
    {
        return _amountCompleted >= _targetAmount;
    }

    public override string GetStatus()
    {
        string box = IsComplete() ? "[X]" : "[ ]";

        return $"{box} {GetName()} ({GetDescription()}) -- Completed {_amountCompleted}/{_targetAmount}";
    }

    public override string GetStringRepresentation()
    {
        return $"ChecklistGoal|{GetName()}|{GetDescription()}|{GetPoints()}|{_amountCompleted}|{_targetAmount}|{_bonus}";
    }
}