using System;

class Program
{
    static void Main(string[] args)
    
    {   
        Console.Clear();
        Console.WriteLine("Welcome to the Scripture Memorizer Tool!");
        Console.WriteLine("\nWould you like to insert your own scripture? (Y/N)");
        string input = Console.ReadLine();

        if (input.ToLower() == "n")
        {
            Reference reference = new Reference("1 Nephi", "1", "3");
            Scripture scripture = new Scripture(reference, "And I know that the record which I make is true; and I make it with mine own hand; and I make it according to my knowledge.");
            Word word = new Word(scripture);

            Console.Clear();
            Console.WriteLine("You will be memorizing 1 Nephi 1:3");
            Console.WriteLine("\nPress enter to continue or type \"quit\" to finish");
            string userInput = Console.ReadLine();

            while (userInput != "quit" && word.IsCompletelyHidden() == true)
            {
                Console.Clear();
                Console.WriteLine(string.Format("{0} {1}", reference.toSingleVerse(), word.toString()));
                Console.WriteLine();
                Console.WriteLine("Press enter to hide words or type \"quit\" to finish");
                word.hide();
                userInput = Console.ReadLine();

            }
        }
        else
        {
            Reference reference = new Reference();
            Scripture scripture = new Scripture();
    
            reference.promptReference();
            scripture.promptScripture();

            Word word = new Word(scripture);

            Console.Clear();
            Console.WriteLine($"You will be memorizing {reference.toSingleVerse()}");
            Console.WriteLine("\nPress enter to continue or type \"quit\" to finish");
            string userInput = Console.ReadLine();

            while (userInput != "quit" && word.IsCompletelyHidden() == true)
            {
                Console.Clear();
                Console.WriteLine(string.Format("{0} {1}", reference.toSingleVerse(), word.toString()));
                Console.WriteLine();
                Console.WriteLine("Press enter to hide words or type \"quit\" to finish");
                word.hide();
                userInput = Console.ReadLine();

            }

        }
    }

}