public class Chaser : Character
{
    public override string RoomChoice(int playerCount, string playerName, List<string> list, string character)
    {
        if (playerCount == 1 || character == "player1")
        {
            bool valid = false;
            List<string> options = new List<string>{"W", "A", "S", "D"};
            int index = -1;
            Console.Clear();
            Console.WriteLine($"{playerName}, which room would you like to search for the Runner?");
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

        }

        else if (playerCount == 2 && character == "player2")
        {
            bool valid = false;
            List<string> options = new List<string>{"I", "J", "K", "L"};
            int index = -1;
            Console.Clear();
            Console.WriteLine($"{playerName}, which room would you like to search for the Runner?");
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
                    case "i":
                    valid = true;
                    _randomString = roomChoice;
                    break;

                    case "j":
                    valid = true;
                    _randomString = roomChoice;
                    break;

                    case "k":
                    valid = true;
                    _randomString = roomChoice;
                    break;

                    case "l":
                    valid = true;
                    _randomString = roomChoice;
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