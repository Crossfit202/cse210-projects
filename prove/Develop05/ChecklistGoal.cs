public class ChecklistGoal : Goal 
{
    private int _timeToComplete;
    private int _hasCompleted = 0;
    private int _bonusPoints;
    public ChecklistGoal()
    {

    }

    public ChecklistGoal(string _goal, string _description, int _pointValue, int timeToComplete, int hasCompleted, int bonusPoints, bool _completed) : base(_goal, _description, _pointValue, _completed)
    {
        _timeToComplete = timeToComplete;
        _hasCompleted = hasCompleted;
        _bonusPoints = bonusPoints;
    }
    public ChecklistGoal(string _goal, string _description, int _pointValue, int timeToComplete, int hasCompleted, int bonusPoints, string _checkBox, int _totalPoints) : base(_goal, _description, _pointValue, _checkBox, _totalPoints)
    {
        _timeToComplete = timeToComplete;
        _hasCompleted = hasCompleted;
        _bonusPoints = bonusPoints;
    }
    public override string Completed(string yesOrNo)
    {
        
        _hasCompleted += 1;

        if (_timeToComplete == _hasCompleted)
        {
            _checkBox = "[X]";
            _completed = true;
            _pointValue = _bonusPoints;
        }

        return _checkBox;
    }

    public override void DisplayGoal()
    {
        if (_completed == true)
        {
            _checkBox = "[X]";
        }
        Console.WriteLine(string.Format("{0}. {1} {2}, ({3}), --- {4}/{5}", _index, _checkBox, _goal, _description, _hasCompleted, _timeToComplete));
    }

    public override void GetInformation()
    {
        Console.Write("What is the name of your goal? ");
        _goal = Console.ReadLine();

        Console.Write("Give a short description of your goal: ");
        _description = Console.ReadLine();

        Console.Write("What is the amount of points associated with this goal? ");
        _pointValue = int.Parse(Console.ReadLine());

        Console.Write("How many times does this goal need to be accomplished for a bonus? ");
        _timeToComplete = int.Parse(Console.ReadLine());

        Console.Write("What is the bonus for accomplishing it that many times? ");
        _bonusPoints = int.Parse(Console.ReadLine());

        _completed = false;

    }

    public override string Format()
    {
        return string.Format("Checklist:{0}|{1}|{2}|{3}|{4}|{5}|{6}", _goal, _description, _pointValue, _hasCompleted, _timeToComplete, _bonusPoints, _completed);
    }

    
}