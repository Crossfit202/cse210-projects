using System;

class Program
{
    static void Main(string[] args)
    {
        
        
        bool playAgain = true;
    
        do
        {
            int numberGuess = 0;
            Random randomGenerator = new Random();
            int magicNumber = randomGenerator.Next (1,50);
            string again = null;
            int attempts = 1;
        
            while (numberGuess != magicNumber)
            {
                Console.Write("What is the magic number? ");
                string newGuess = Console.ReadLine();
                numberGuess = int.Parse(newGuess);
                // determine is numbers match

                if (numberGuess > magicNumber)
                {
                    Console.WriteLine("Lower");
                    attempts = attempts + 1;
                }
                else if (numberGuess < magicNumber)
                {
                    Console.WriteLine("Higher");
                    attempts = attempts + 1;
                }
                else 
                {
                    Console.WriteLine("You guessed it!");
                    Console.WriteLine($"It took you {attempts} tries");
                    Console.Write("Would you like to play again? ");
                    again = Console.ReadLine();
                }

                // Determine is user wants to keep playing
                if (again == "yes")
                {
                    playAgain = true;
                }
                else
                {
                    playAgain = false;
                }
            }

        } while (playAgain == true);
        
        
    }    
    
}