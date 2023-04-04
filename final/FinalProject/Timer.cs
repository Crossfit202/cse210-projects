public class Timer
{
    private int _duration; 
    private int _level;

    public void SetDuration()
    {
        Console.Write("How many rounds would you like to play? (up to 10) ");
        _duration = int.Parse(Console.ReadLine());
    }

    public void SetLevel()
    {
        Console.WriteLine("What level would you like to play on?");
        Console.WriteLine(" 1. Easy \n 2. Medium \n 3. Hard");
        int input = int.Parse(Console.ReadLine());

        switch(input)
        {
            case 1:
            _duration = 3;
            _level = 1;
            break;

            case 2:
            _duration = 3;
            _level = 2;
            break;

            case 3:
            _duration = 3;
            _level = 3;
            break;

        }
    }

    public int GetLevel()
    {
        return _level;
    }

    public int GetDuration()
    {
        return _duration;
    }

    public void Spinner(int timeToRun)
    {
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(timeToRun);
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
}