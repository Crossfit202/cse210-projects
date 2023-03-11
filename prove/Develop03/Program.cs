using System;

class Program
{
    static void Main(string[] args)
    
    {   
        Console.Clear();
        Console.WriteLine("Welcome to the Scripture Memorizer Tool!");
        Console.WriteLine("\nWould you like to enter your own scripture? (Y/N)");
        string input = Console.ReadLine();
        
        if (input.ToLower() == "n")
        {
        
            Console.Clear();
            Console.WriteLine("How many words would you like to hide each round?");
            string I = Console.ReadLine();
            int inputNum = int.Parse(I);
            
            Reference reference = new Reference("1 Nephi", "1", "3");
            Scripture scripture = new Scripture(reference, "And I know that the record which I make is true; and I make it with mine own hand; and I make it according to my knowledge.", inputNum);
            

            Console.Clear();
            Console.WriteLine("You will be memorizing 1 Nephi 1:3");
            Console.WriteLine("\nPress enter to continue or type \"quit\" to finish");
            string userInput = Console.ReadLine();
            scripture.makeList();
            reference.toSingleVerse();
            scripture.displayScripture();

            do
            {
                Console.Clear();
                scripture.displayScripture();
                Console.WriteLine();
                Console.WriteLine("Press enter to hide words or type \"quit\" to finish");
                userInput = Console.ReadLine();
                scripture.hideRandomWords();
            }while (userInput != "quit" && scripture.IsCompletelyHidden() == false);
    
        }

        else if (input.ToLower() == "y" )
        {        
            Reference reference = new Reference();
            reference.promptReference();

            Scripture scripture = new Scripture(reference);
            scripture.promptScriptureAndWords();

            Console.Clear();
            Console.WriteLine($"You will be memorizing {reference.toSingleVerse()}");
            Console.WriteLine("\nPress enter to continue or type \"quit\" to finish");
            string userInput = Console.ReadLine();
            scripture.makeList();
            scripture.displayScripture();

            do
            {
                Console.Clear();
                scripture.displayScripture();
                Console.WriteLine();
                Console.WriteLine("Press enter to hide words or type \"quit\" to finish");
                userInput = Console.ReadLine();
                scripture.hideRandomWords();
            }while (userInput != "quit" && scripture.IsCompletelyHidden() == false);
        }
    }
}

