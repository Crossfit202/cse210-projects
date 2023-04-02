using System;
class Program
{
    static void Main(string[] args)
    {
        
        Timer timer = new Timer();
        Selector selector = new Selector();

        Console.Clear();
        Console.WriteLine("Welcome to Escape the Mansion!");
        Thread.Sleep(3000);
        Console.WriteLine();
       
        Menu menu = new Menu();
        menu.CreateMenu();
        int userInput = menu.GetInput();

        while (userInput != 3)
        {
            
            menu.DisplayMenu();
            userInput = menu.GetInput();

            switch (userInput)
            {
                case 1: //Play against computer

                CPU computer = new CPU();
                Player player = new Player();
                
                Console.Clear();
                player.SetName();
                string playerName = player.GetName();
                player.SetCharacter(1, false, "none");
                timer.SetDuration();
                int duration = timer.GetDuration();
                
                menu.PrintMessage("In this gamemode you will play against the computer. \nYou will use W A S and D to make your choice");

                selector.MakeList();

                while (duration != 0)
                {
                    
                    List<string> randomRooms = selector.SelectRandomRooms();
                    List<string> options = new List<string> {"W", "A", "S", "D"};
                    int index = -1;
                    bool valid = false;
                    string randomRoomOne = randomRooms[0];
                    string randomRoomTwo = randomRooms[1];
                    string randomRoomThree = randomRooms[2];
                    string randomRoomFour = randomRooms[3];

                    Console.Clear();
                    Console.WriteLine($"{playerName}, which room would you like to run to and hide in?"); 
                    foreach (string room in randomRooms)
                    {
                        Console.WriteLine($" {options[index + 1]}. {room}");
                        index = index + 1;
                    }
                    
                    string roomChoice = Console.ReadLine();
                    
                    while (valid != true)
                    {
                        switch (roomChoice.ToUpper())
                        {
                            case "W":
                            selector.RemoveFromList(randomRoomOne);
                            duration = duration - 1;
                            valid = true;
                            break;

                            case "A":
                            selector.RemoveFromList(randomRoomTwo);
                            duration = duration - 1;
                            valid = true;
                            break;

                            case "S":
                            selector.RemoveFromList(randomRoomThree);
                            duration = duration - 1;
                            valid = true;
                            break;

                            case "D":
                            selector.RemoveFromList(randomRoomFour);
                            duration = duration - 1;
                            valid = true;
                            break;

                            default:
                            Console.WriteLine("That is not a valid entry. Please enter either W, A, S, or D.");
                            valid = false;
                            break;
                        }
                    }
                    
                    
                }
                
                selector.Exit(playerName);

                break; 

                case 2: // Play against another player

                Console.Clear();

                Player p1 = new Player();
                Player p2 = new Player();

                Console.WriteLine("Player 1");
                p1.SetName();
                p1.SetCharacter(2, false, "none");
                Console.WriteLine("Player 2");
                p2.SetName();

                p2.SetCharacter(2, true, p1.GetCharacter());
                timer.SetDuration();

                menu.PrintMessage("In this gamemode, you will be playing against each other. One of you in the runner and the other is the chaser. \nPlayer 1. You will use W A S and D to make your choice. \nPlayer 2. You will use I J K and L to make your choice.");
                break;

                case 3: 
                break;

                

                default:
                Console.WriteLine("That is not a valid entry");
                Console.WriteLine("Please enter a number between 1 and 3");
                Thread.Sleep(3000);
                break;
            }
        }

        
        
        
    }
}
