public class CPU : Character
{
    
    private int _level;

    public CPU(int level)
    {
        _level = level;
    }

    public override string RoomChoice(string playerName, List<string> randomRooms)
    {

        Timer timer = new Timer();
        
        
        switch(_level)
        {
            case 1:
            List<string> options = new List<string>{"W", "A", "S", "D"};
            Random random = new Random();
            int index = random.Next(options.Count);
            _randomString = options[index];

            Console.WriteLine("The Computer is choosing a room");
            timer.Spinner(2);
            break;

            case 2:
            List<string> options2 = new List<string>{"W", "A", "S"};
            Random random2 = new Random();
            int index2 = random2.Next(options2.Count);
            _randomString = options2[index2];

            Console.WriteLine("The Computer is choosing a room");
            timer.Spinner(2);
            break;

            case 3:
            List<string> options3 = new List<string>{"W", "A"};
            Random random3 = new Random();
            int index3 = random3.Next(options3.Count);
            _randomString = options3[index3];

            Console.WriteLine("The Computer is choosing a room");
            timer.Spinner(2);
            break;
        }
        
        return _randomString;

    }
}