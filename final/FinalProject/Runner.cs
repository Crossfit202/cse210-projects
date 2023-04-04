public class Runner : Character 
{
    private int _lives;

    public void LoseLife()
    {
        _lives -= 1;
    }

    public override string RoomChoice(string playerName, List<string> list)
    {
        bool valid = false;
        List<string> options = new List<string>{"W", "A", "S", "D"};
        int index = -1;
        Console.Clear();
        Console.WriteLine($"{playerName}, which room would you like to run to and hide in?");
        
        foreach (string room in list)
            {
                Console.WriteLine($" {options[index + 1]}. {room}");
                index = index + 1;
            } 
        
        
            
        while (valid != true)
        {
            string roomChoice = Console.ReadLine().ToLower();

            switch(roomChoice)
            {
                case "w":
                valid = true;
                _randomString = roomChoice;
                break;

                case "a":
                valid = true;
                _randomString = roomChoice;
                break;

                case "s":
                valid = true;
                _randomString = roomChoice;
                break;

                case "d":
                valid = true;
                _randomString = roomChoice;
                break;

                default:
                Console.WriteLine("That is not a valid entry. Please try again");
                break;
            }

        }
        
        return _randomString;
    }

  
}