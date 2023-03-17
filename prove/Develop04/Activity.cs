public class Activity
{
    protected string _activityName; 

    protected int _duration; 

    protected string _description;

    public Activity()
    {

    }
    public Activity(string activityName, string description, int duration)
    {
        _activityName = activityName;
        _description = description;
        _duration = duration;
    }

    public Activity(string activityName, string description)
    {
        _activityName = activityName;
        _description = description;
        _duration = 30;
    }


    public void Display()
    {
        Console.WriteLine($"Welcome to the {_activityName}!");
        Console.WriteLine($"\n{_description}");
    }
    
    public void MakeSpinner(string message, int timeToRun)
    {
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(timeToRun);
        
        Console.Write(message);
        while (DateTime.Now < futureTime)
        {
            
            Console.Write("|");
            Thread.Sleep(300);
            Console.Write("\b \b");
            Console.Write("/");
            Thread.Sleep(300);
            Console.Write("\b \b");
            Console.Write("-");
            Thread.Sleep(300);
            Console.Write("\b \b");
        }

    }

    

    public void GetDuration()
    {
        Console.Write("\nHow long, in seconds, would you like your session to last?: ");
        string duration = Console.ReadLine();
        _duration = int.Parse(duration);
    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine();
        MakeSpinner("\nWell done ", 2);
        Console.WriteLine();
        MakeSpinner($"\nYou have completed {_duration} seconds of the {_activityName} ", 2);
    }
    public void MakeTimer(int seconds, DateTime time)
    {
        

        Console.Write(seconds);

        do 
        {   
            Thread.Sleep(1000);
            Console.Write("\b \b");
            Console.Write(seconds - 1);
            seconds = seconds - 1;
        } while (seconds != 0 && DateTime.Now < time);
    }

    public void MakeCountdown(int seconds)
    {
        

        Console.Write(seconds);

        do 
        {   
            Thread.Sleep(1000);
            Console.Write("\b \b");
            Console.Write(seconds - 1);
            seconds = seconds - 1;
        } while (seconds != 0);
    }

    public DateTime GetTime()
    {
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(_duration);

        return futureTime;
    }
}