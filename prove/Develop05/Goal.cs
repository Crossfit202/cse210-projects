using System.IO;
public class Goal 
{
    protected List<Goal> _goalsList = new List<Goal>();
    protected List<string> _listFromFile = new List<string>();
    protected string _goal; 
    protected string _description; 
    protected int _pointValue; 
    protected bool _completed; 
    protected string _checkBox = "[ ]";

    protected int _index = 0;

    private int _totalPoints = 0;


    public Goal()
    {

    }

    public Goal(string goal, string description, int pointValue, bool completed)
    {
        _goal = goal;
        _description = description;
        _pointValue = pointValue;
        _completed = completed;
        
    }

    public Goal(string goal, string description, int pointValue, string checkBox, int totalPoints)
    {
        _goal = goal;
        _description = description;
        _pointValue = pointValue;
        _checkBox = checkBox;
    }


    public Goal(string goal, string description, int pointValue)
    {
        _goal = goal;
        _description = description;
        _pointValue = pointValue;
    }

    public int GetTotalPoints()
    {
        return _totalPoints;
    }

    public virtual void DisplayGoal()
    {
        if (_completed == true)
        {
            _checkBox = "[X]";
        }
        Console.WriteLine(string.Format("{0}. {1} {2}, ({3})", _index, _checkBox, _goal, _description));
    }

    public virtual string Completed(string yesOrNo)
    {
        _completed = false;
        _checkBox = "[ ]";

        if (yesOrNo == "true")
        {
            _completed = true;
            _checkBox = "[X]";
        }

        return _checkBox;
        
        
    }

    public bool IsComplete()
    {
        return _completed;
    }

    public virtual void GetInformation()
    {
        Console.Write("What is the name of your goal? ");
        _goal = Console.ReadLine();

        Console.Write("Give a short description of your goal: ");
        _description = Console.ReadLine();

        Console.Write("What is the amount of points associated with this goal? ");
        _pointValue = int.Parse(Console.ReadLine());

        _completed = false;
        
    }

    public virtual string Format()
    {
        return string.Format("{0}|{1}|{2}|{3}", _goal, _description, _pointValue, _completed);
    }
    
    public void SaveToCSV(int totalPoints)
    {     
        Console.WriteLine("Name of file to save?");
        string _fileName = Console.ReadLine();

        using (StreamWriter outputFile = new StreamWriter(_fileName))
        {
            outputFile.WriteLine(totalPoints);

            foreach (Goal g in _goalsList)
            {
                outputFile.WriteLine(g.Format());
            }
        }
        
    }

     public int LoadFromCSV()
    {
        Console.WriteLine("Name of file to load?");
        string _fileName = Console.ReadLine();
        Console.Clear();

        using (StreamReader reader = new StreamReader(_fileName))
        {
            // Read and discard the first line of the file
            string firstLine = reader.ReadLine();
        
            int totalPoints = int.Parse(firstLine);

            // Read the rest of the lines in the file
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                // Do something with each line, such as print it to the console
                string[] words = line.Split(":");
                
                string title = words[0];
                string details = words[1];

                MakeGoal(title, details);
                     
            }
            return totalPoints;
        }
        
        
    }

    public void MakeGoal(string title, string details)
    {
        if (title == "Simple")
        {
            string[] words = details.Split("|");
            
            SimpleGoal simple = new SimpleGoal(words[0], words[1], int.Parse(words[2]), bool.Parse(words[3]));
            _goalsList.Add(simple);
        }

        else if (title == "Eternal")
        {
            string[] words = details.Split("|");

            EternalGoal eternal = new EternalGoal(words[0], words[1], int.Parse(words[2]), bool.Parse(words[3]));
            _goalsList.Add(eternal);
        }

        else if (title == "Checklist")
        {
            string[] words = details.Split("|");

            ChecklistGoal checklist = new ChecklistGoal(words[0], words[1], int.Parse(words[2]), int.Parse(words[4]), int.Parse(words[3]), int.Parse(words[5]), bool.Parse(words[6]));
            _goalsList.Add(checklist);
        }

        else
        {
            
        }
        
    }

    public List<Goal> GetGoals()
    {
            return _goalsList;
    }

    public int GetPointValue()
    {
        return _pointValue;
    }

    public void SetIndex(int num)
    {
        _index = num;
    }

    public int GetIndex()
    {
        return _index;
    }

    public void DisplayList()
    {
        Console.Clear();
            int index = 0;
            foreach (Goal g in _goalsList)
            {
                g.SetIndex(index += 1); 
                g.DisplayGoal();
                  
            }
            
    }

    
}