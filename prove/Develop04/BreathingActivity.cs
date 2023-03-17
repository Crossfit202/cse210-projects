public class BreathingActivity : Activity
{
    private int _breatheInTime;
    private int _breatheOutTime;
    
    public BreathingActivity()
    {
        _breatheInTime = 5;
        _breatheOutTime = 5;
    }

    public BreathingActivity(string _activityName, string _description, int breatheInTime, int breatheOutTime) : base(_activityName, _description)
    {
        _breatheInTime = breatheInTime;
        _breatheOutTime = breatheOutTime;
    }

    

    public void Instruction()
    {
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(_duration);
        
        do 
        {
            
            Console.WriteLine();
            Console.Write($"\nBreathe in...");
            MakeTimer(_breatheInTime, futureTime);
            
            Console.WriteLine();
            
            Console.Write($"\nBreathe out...");
            MakeTimer(_breatheOutTime, futureTime);
           
        } while (DateTime.Now < futureTime);
    }

    
    

}