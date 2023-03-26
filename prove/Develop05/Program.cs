using System;

class Program
{
    static void Main(string[] args)
    {
        Levels levels = new Levels();
        Goal goal = new Goal();
        int userInputNum = 0;
        int totalPoints = 0;
        

        while (userInputNum != 6)
        {
            
            Console.Clear(); 
            Console.WriteLine($"You have {totalPoints} points.");
            Console.WriteLine(levels.DetermineLevel(totalPoints));
            Console.WriteLine();
            Console.WriteLine("Menu Options \n 1. Create New Goal \n 2. List Goals \n 3. Save Goals \n 4. Load Goals \n 5. Record Event \n 6. Quit");
            Console.Write("Select a choice from the menu: ");

            string userInput = Console.ReadLine();
            userInputNum = int.Parse(userInput);

            switch (userInputNum)
        {
            case 1: //Make new Goal 
            Console.Clear();
            Console.WriteLine("The types of Goals are: \n 1. Simple Goal \n 2. Eternal Goal \n 3. Checklist Goal");
            Console.Write("Which type of goal would you like to create? ");

            
            int goalInputNum = int.Parse(Console.ReadLine());

            switch (goalInputNum)
            {
                case 1: // Make new simple goal 
                SimpleGoal simpleGoal = new SimpleGoal();
                goal.GetGoals().Add(simpleGoal);
                simpleGoal.GetInformation();
                break;

                case 2: //make new eternal goal 
                EternalGoal eternalGoal = new EternalGoal();
                goal.GetGoals().Add(eternalGoal);
                eternalGoal.GetInformation();
                break;

                case 3: //make new checklist goal 
                ChecklistGoal checklistGoal = new ChecklistGoal();
                goal.GetGoals().Add(checklistGoal);
                checklistGoal.GetInformation();
                break; 

                default: //make them retry 
                Console.WriteLine("That is not a valid number");
                Console.WriteLine("Please enter a number 1-3");
                Thread.Sleep(3000);
                break;
                
            }
            break;

            case 2: //Display goals 
            goal.DisplayList();
            Console.WriteLine("Press enter to continue");
            Console.ReadLine();
            break;

            case 3: //save the goals 
            goal.SaveToCSV(totalPoints);
            break;

            case 4://load the goals from file. 
            totalPoints = goal.LoadFromCSV();
            
            break;

            case 5: //Make an entry
            goal.DisplayList();

            Console.WriteLine("Which goal would you like to record?");
            int input = int.Parse(Console.ReadLine());

            foreach (Goal g in goal.GetGoals())
            {
                if (g.GetIndex() == input && g.IsComplete() == false )
                {
                   g.Completed("true");
                   int pointValue = g.GetPointValue();
                   totalPoints += pointValue;

                   Console.WriteLine($"Congratulations! You have earned {pointValue}!");
                   Console.WriteLine();
                   Console.WriteLine($"You now have {totalPoints} points.");
                   Console.WriteLine("Press enter to continue");
                   Console.ReadLine();
                }

                else if(g.GetIndex() == input && g.IsComplete() == true && g is SimpleGoal)
                {
                    Console.WriteLine("This Simple goal has already been marked off");
                    Console.WriteLine("Press enter to continue");
                    Console.ReadLine();
                }

                else if (g.GetIndex() == input && g.IsComplete() == false && g is ChecklistGoal)
                {
                   g.Completed("true");
                   int pointValue = g.GetPointValue();
                   totalPoints += pointValue;

                   Console.WriteLine($"Congratulations! You have earned {pointValue}!");
                   Console.WriteLine();
                   Console.WriteLine($"You now have {totalPoints} points.");
                   Console.WriteLine("Press enter to continue");
                   Console.ReadLine();
                }
                
                else if (g.GetIndex() == input && g.IsComplete() == true && g is ChecklistGoal)
                {
                
                   Console.WriteLine("That Checklist Goal has already been completed");
                   Console.WriteLine("Press enter to continue");
                   Console.ReadLine();
                }

            }
            break; 

            case 6: //quit 
            break;

            default: //make them try again
            Console.WriteLine("That is not a valid number");
            Console.WriteLine("Please enter a number between 1 and 6");
            Thread.Sleep(3000);
            break;
        }

        }
        
    }
}