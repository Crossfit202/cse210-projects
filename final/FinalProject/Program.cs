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
                timer.SetLevel();
                int level = timer.GetLevel();
                CPU computer = new CPU(level);
                int duration = timer.GetDuration();
                int newDuration = duration;
                int hideSuccess = 0; 
                int findSuccess = 0;
                
                menu.PrintMessage("In this gamemode you will play against the computer. \nYou will use W A S and D to make your choice");
            

                selector.MakeList();

                do
                {
                    List<string> randomRooms = selector.SelectRandomRooms(level); //List of 4 random rooms
                    
                    string choice;
                    string choice2;
                    

                    if (player.GetCharacter().ToString() == "Runner")
                    {
                        choice = player.GetCharacter().RoomChoice(playerName, randomRooms);
                        choice2 = computer.RoomChoice("Computer", randomRooms);
                        
                        selector.RemoveFromList(choice);
                        bool gotCaught = compare.Compare(choice, choice2);

                        if(gotCaught)
                        {
                            selector.Lose(player.GetCharacter().ToString());
                            timer.Spinner(5);
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
                        choice2 = computer.RoomChoice("Computer", randomRooms);
                        choice = player.GetCharacter().RoomChoice(playerName, randomRooms);
                        selector.RemoveFromList(choice);
                        bool gotCaught = compare.Compare(choice, choice2);
                        if(gotCaught)
                        {
                            selector.Win(playerName, player.GetCharacter().ToString());
                            timer.Spinner(5);
                            findSuccess += 1;
                            newDuration = 0;
                        }
                        else if (gotCaught == false)
                        {
                            Console.WriteLine("The Runner was not found by the Chaser");
                            timer.Spinner(2);
                            newDuration = (newDuration - 1); 
                        }                            
                        
                    }

                    
                } while (newDuration != 0);

                if (hideSuccess == duration)
                {
                    selector.Win(playerName, "runner");
                    timer.Spinner(5);
                }

                else if (findSuccess == 1)
                {
                    selector.Win(playerName, "chaser");
                    timer.Spinner(5);
                }
                    
                break; 

                case 2: // Play against another player

               // CPU computer = new CPU();
               // Player player = new Player(); 
               // 
               // Console.Clear();
               // player.SetName();
               // string playerName = player.GetName();
               // player.SetCharacter(1, false, "none");
               // timer.SetDuration();
               // int duration = timer.GetDuration();
               // int newDuration = duration;
               // int hideSuccess = 0; 
               // int findSuccess = 0;
               // 
               // menu.PrintMessage("In this gamemode you will play against the computer. \nYou will use W A S and D to make your choice");
            //
//
               // selector.MakeList();
//
               // do
               // {
               //     List<string> randomRooms = selector.SelectRandomRooms(); //List of 4 random rooms
               //     string randomRoomOne = randomRooms[0];
               //     string randomRoomTwo = randomRooms[1];
               //     string randomRoomThree = randomRooms[2];
               //     string randomRoomFour = randomRooms[3];
               //     string choice;
               //     string choice2;
               //     
//
               //     if (player.GetCharacter().ToString() == "Runner")
               //     {
               //         choice = player.GetCharacter().RoomChoice(playerName, randomRooms);
               //         choice2 = computer.RoomChoice("Computer", randomRooms);
               //         
               //         selector.RemoveFromList(choice);
               //         bool gotCaught = compare.Compare(choice, choice2);
//
               //         if(gotCaught)
               //         {
               //             selector.Lose(player.GetCharacter().ToString());
               //             timer.Spinner(5);
               //             newDuration = 0;
               //         }
               //         else if (gotCaught == false)
               //         {
               //             Console.WriteLine("The Runner was not found by the Chaser");
               //             timer.Spinner(2);
               //             hideSuccess += 1;
               //             newDuration = (newDuration - 1);
               //         }
    //
               //     }
//
               //     else if (player.GetCharacter().ToString() == "Chaser")
               //     {
               //         choice2 = computer.RoomChoice("Computer", randomRooms);
               //         choice = player.GetCharacter().RoomChoice(playerName, randomRooms);
               //         selector.RemoveFromList(choice);
               //         bool gotCaught = compare.Compare(choice, choice2);
               //         if(gotCaught)
               //         {
               //             selector.Win(playerName, player.GetCharacter().ToString());
               //             timer.Spinner(5);
               //             findSuccess += 1;
               //             newDuration = 0;
               //         }
               //         else if (gotCaught == false)
               //         {
               //             Console.WriteLine("The Runner was not found by the Chaser");
               //             timer.Spinner(2);
               //             newDuration = (newDuration - 1); 
               //         }                            
               //         
               //     }
//
               //     
               // } while (newDuration != 0);
//
               // if (hideSuccess == duration)
               // {
               //     selector.Win(playerName, "runner");
               //     timer.Spinner(5);
               // }
//
               // else if (findSuccess == 1)
               // {
               //     selector.Win(playerName, "chaser");
               //     timer.Spinner(5);
               // }

                
                break;
            }
        }

        
        
        
    }
}
