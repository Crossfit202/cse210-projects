public class Runner : Character 
{
    

    public override string RoomChoice(int playerCount, string playerName, List<string> list, string character)
    {
        if(playerCount == 1 || character == "player1")
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
                ConsoleKeyInfo key = Console.ReadKey();

                switch(key.Key)
                {
                    case ConsoleKey.W:
                    valid = true;
                    _randomString = ConsoleKey.W.ToString();
                    break;

                    case ConsoleKey.A:
                    valid = true;
                    _randomString = ConsoleKey.A.ToString();
                    break;

                    case ConsoleKey.S:
                    valid = true;
                    _randomString = ConsoleKey.S.ToString();
                    break;

                    case ConsoleKey.D:
                    valid = true;
                    _randomString = ConsoleKey.D.ToString();
                    break;

                    default:
                    Console.WriteLine("That is not a valid entry. Please try again");
                    break;
                }

            }

        }

        else if (playerCount == 2 && character == "player2")
        {
            bool valid = false;
            List<string> options = new List<string>{"I", "J", "K", "L"};
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
                ConsoleKeyInfo key = Console.ReadKey();

                switch(key.Key)
                {
                    case ConsoleKey.I:
                    valid = true;
                    _randomString = ConsoleKey.I.ToString();
                    break;

                    case ConsoleKey.J:
                    valid = true;
                    _randomString = ConsoleKey.I.ToString();
                    break;

                    case ConsoleKey.K:
                    valid = true;
                    _randomString = ConsoleKey.I.ToString();
                    break;

                    case ConsoleKey.L:
                    valid = true;
                    _randomString = ConsoleKey.I.ToString();
                    break;

                    default:
                    Console.WriteLine("That is not a valid entry. Please try again");
                    break;
                }

            }

        }
        
       
        
        return _randomString;
    }

  
}