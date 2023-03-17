using System;

class Program
{
    static void Main(string[] args)
    {
        int userInput = 0;
        Console.Clear();
        

        while (userInput != 5)
        {
            Console.Clear();
            Console.WriteLine("Welcome to the Mindfulness Helper!");
            Console.WriteLine("\nMenu Options:");
            Console.WriteLine(" 1. Start breathing activity \n 2. Start reflecting activity \n 3. Start listing activity \n 4. Body focus activity \n 5. Quit");
            Console.Write("Select a choice from the menu: ");
            userInput = int.Parse(Console.ReadLine());

            switch (userInput)
            {
                case 1:
                    Console.Clear();
                    BreathingActivity bActivity = new BreathingActivity("Breathing Activity", "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing", 5, 6);
                    bActivity.Display();
                    bActivity.GetDuration();
                    Console.Clear();
                    bActivity.MakeSpinner("Get ready...", 3);
                    bActivity.Instruction();
                    bActivity.DisplayEndingMessage();
                    break;

                case 2:
                    Console.Clear();
                    ReflectionActivity rActivity = new ReflectionActivity("Reflection Activity", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life");
                    rActivity.MakeReflectionPrompts();
                    rActivity.MakeReflectionQuestions();
                    rActivity.Display();
                    rActivity.GetDuration();
                    Console.Clear();
                    rActivity.MakeSpinner("\nGet Ready...", 3);
                    Console.WriteLine();
                    rActivity.DisplayRandomReflectionPrompt();
                    rActivity.DisplayRandomQuestion();
                    rActivity.DisplayEndingMessage();
                    break;
                case 3:
                    Console.Clear();
                    ListingActivity lActivity = new ListingActivity("Listing Activity", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
                    lActivity.MakeListingPrompts();
                    lActivity.Display();
                    lActivity.GetDuration();
                    Console.WriteLine();
                    lActivity.DisplayRandomListingPrompt();
                    lActivity.UserWrites();
                    lActivity.DisplayEndingMessage();
                    break;
                
                case 4:
                    Console.Clear();
                    BodyFocusActivity bfActivity = new BodyFocusActivity("Body Focus Activity", "This activity will guide you through focusing on specific body parts from your head to your feet. This helps to reduce physical tension in the muscles, which is often associated with stress and anxiety. By consciously relaxing the muscles, you can signal to your body that it is safe to let go of tension and enter a more relaxed state.");
                    bfActivity.MakeBodyPartList();
                    bfActivity.Display();
                    bfActivity.GetDuration();
                    bfActivity.MakeSpinner("Get Ready... ", 3);
                    bfActivity.ListBodyParts();
                    bfActivity.DisplayEndingMessage();
                    break;

                case 5: 
                    break;
                
                default:
                    Console.WriteLine("That was not a valid number");
                    Thread.Sleep(2000);
                    break; 
            


            }

        }
        


    }
}