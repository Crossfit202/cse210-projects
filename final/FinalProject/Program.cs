using System;
class Program
{
    static void Main(string[] args)
    {
        
        Timer timer = new Timer();
        Selector selector = new Selector();
        Comparator compare = new Comparator();

        Console.Clear();
        Console.WriteLine("Welcome to The Mansion!");
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

                Player player = new Player(); 
                
                Console.Clear();
                player.SetName();
                string playerName = player.GetName();
                player.SetCharacter(1, false, "none");
                timer.SetLevel(player.GetCharacter().ToString());
                int level = timer.GetLevel();
                CPU computer = new CPU(level);
                int duration = timer.GetDuration();
                int newDuration = duration;
                int hideSuccess = 0; 
                int findSuccess = 0;
                int ComHideSuccess = 0;
                
                menu.PrintMessage("In this gamemode you will play against the computer. \nYou will use W A S and D to make your choice");
            

                selector.MakeList();

                do
                {
                    List<string> randomRooms = selector.SelectRandomRooms(level); //List of 4 random rooms
                    
                    string choice;
                    string choice2;
                    

                    if (player.GetCharacter().ToString() == "Runner")
                    {
                        choice = player.GetCharacter().RoomChoice(1, playerName, randomRooms, "player1");
                        choice2 = computer.RoomChoice(1, "Computer", randomRooms, "computer");
                        
                        selector.RemoveFromList(choice);
                        bool gotCaught = compare.Compare(choice, choice2);

                        if(gotCaught)
                        {
                            selector.Lose(player.GetCharacter().ToString());
                            timer.Spinner(3);
                            newDuration = 0;
                        }
                        else if (gotCaught == false)
                        {
                            Console.WriteLine("The Runner was not found by the Chaser");
                            timer.Spinner(2);
                            hideSuccess += 1;
                            newDuration = (newDuration - 1);
                        }
    
                    }

                    else if (player.GetCharacter().ToString() == "Chaser")
                    {
                        choice2 = computer.RoomChoice(1, "Computer", randomRooms, "computer");
                        choice = player.GetCharacter().RoomChoice(1, playerName, randomRooms, "player1");
                        selector.RemoveFromList(choice);
                        bool gotCaught = compare.Compare(choice, choice2);
                        if(gotCaught)
                        {
                            selector.Win(playerName, player.GetCharacter().ToString());
                            timer.Spinner(3);
                            findSuccess += 1;
                            newDuration = 0;
                        }
                        else if (gotCaught == false)
                        {
                            Console.WriteLine("The Runner was not found by the Chaser");
                            timer.Spinner(2);
                            ComHideSuccess +=1;
                            newDuration = (newDuration - 1); 
                        }                            
                        
                    }

                    
                } while (newDuration != 0);

                if (hideSuccess == duration)
                {
                    selector.Win(playerName, "runner");
                    timer.Spinner(3);
                }

                else if (findSuccess == 1)
                {
                    selector.Win(playerName, "chaser");
                    timer.Spinner(3);
                }

                else if (ComHideSuccess == duration)
                {
                    selector.Lose("chaser");
                }
                    
                break; 

                case 2: // Play against another player

                Player playerOne = new Player(); 
                Player playerTwo = new Player();

                Console.Clear();
                Console.WriteLine("Player 1");
                playerOne.SetName();
                Console.WriteLine("\nPlayer 2");
                playerTwo.SetName();
                string playerOneName = playerOne.GetName();
                string playerTwoName = playerTwo.GetName();
                Console.WriteLine("\nPlayer 1:");
                playerOne.SetCharacter(2, false, "none");
                playerTwo.SetCharacter(2, true, playerOne.GetCharacter().ToString());
                timer.SetDuration();
                int oldDuration = timer.GetDuration();
                int currentDuration = oldDuration;
                bool won = false;
                int hiderSuccess =0;
                
                Console.Clear();
                menu.PrintMessage("In this gamemode you will play against each other. \n Player 1: You will use W A S and D to make your choice. \n Player 2: You will use I J K and L to choose. \nGood luck!");
                selector.MakeList();
                
                do
                {
                    List<string> randomRooms = selector.SelectRandomRooms(1); //List of 4 random rooms
                
                    string choice;
                    string choice2;

                        if (playerOne.GetCharacter().ToString() == "Runner")
                    {
                        choice = playerOne.GetCharacter().RoomChoice(2, playerOneName, randomRooms, "player1");
                        choice2 = playerTwo.GetCharacter().RoomChoice(2, playerTwoName, randomRooms, "player2");

                        selector.RemoveFromList(choice);
                        bool gotCaught = compare.CompareTwoPlayer(choice, choice2);
                        
                        if(gotCaught)
                        {
                            selector.Win(playerTwoName, "chaser");
                            timer.Spinner(3);
                            currentDuration = 0;
                        }

                        else if (gotCaught == false)
                        {
                            Console.WriteLine("The Runner was not found by the Chaser");
                            timer.Spinner(2);
                            hiderSuccess += 1;
                            currentDuration = (currentDuration - 1);
                            
                            if (hiderSuccess == oldDuration)
                            {
                                won = true;
                            }    
                        }
                    }

                        else if (playerOne.GetCharacter().ToString() == "Chaser")
                    {
                        choice2 = playerTwo.GetCharacter().RoomChoice(2, playerTwoName, randomRooms, "player2");
                        choice = playerOne.GetCharacter().RoomChoice(2, playerOneName, randomRooms, "player1");
                        selector.RemoveFromList(choice);
                        bool gotCaught = compare.CompareTwoPlayer(choice, choice2);

                        if(gotCaught)
                        {
                            selector.Win(playerOneName, "chaser");
                            timer.Spinner(3);
                            currentDuration = 0;
                        }
                        else if (gotCaught == false)
                        {
                            Console.WriteLine("The Runner was not found by the Chaser");
                            timer.Spinner(2);
                            hiderSuccess += 1;
                            currentDuration = (currentDuration - 1);
                        
                            if (hiderSuccess == oldDuration) 
                            {
                                won = true;
                            }
                        }                            

                    }

                } while (currentDuration != 0);
                
                
                if (won == true)
                {
                    if (playerOne.GetCharacter().ToString().ToLower() == "runner")
                    {
                        selector.Win(playerOneName, "runner");
                        timer.Spinner(3);   
                    }

                    else 
                    {
                        selector.Win(playerTwoName, "runner");
                        timer.Spinner(3);
                    }
                }
                
            
                break;
            }
        }

        
        
        
    }
}
