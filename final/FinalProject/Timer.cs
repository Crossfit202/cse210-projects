public class Timer
{
    private int _duration; 

    public void SetDuration()
    {
        Console.Write("How many rounds would you like to play? (up to 10) ");
        _duration = int.Parse(Console.ReadLine());
    }

    public int GetDuration()
    {
        return _duration;
    }
}