using System;

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        
        int input = 0;

        List<string> menu = new List<string>
        {
            "\nPlease select one of the following choices:",
            "1. Write",
            "2. Display",
            "3. Save",
            "4. Load",
            "5. Quit",
        };

        while (input != 5)
        {
            
            foreach (string menuItem in menu)
            {
                Console.WriteLine(menuItem);
            }
            Console.Write("What would you like to do? ");
            input = int.Parse(Console.ReadLine());

            switch (input)
            {
                case 1:
                    journal.MakeNewEntry();
                    break;

                case 2:
                    journal.DisplayEntries();
                    break;
                case 3:
                    journal.SaveToCSV();
                    break;
                case 4:
                    journal.LoadFromCSV();
                    break;
                default:
                    Console.WriteLine("That was not a valid number");
                    break; 
            


            }
        }
    }
}

