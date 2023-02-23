using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? (0-100) ");
        string gradePercent = Console.ReadLine();
        int percent = int.Parse(gradePercent);
        string letter = null;

        //Determine the grade letter 

        if (percent >= 90)
        {
            letter = "A";
        }
        else if (percent >= 80)
        {
            letter = "B";
        }
        else if (percent >= 70)
        {
            letter = "C";
        }
        else if (percent >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }
        
        // Determine whether to include plus or minus
        string plusOrMinus = null;
        
        if (percent % 10 >= 7)
        {
            plusOrMinus = "+";
        }
        else if (percent % 10 < 3)
        {
            plusOrMinus = "-";
        }
        else 
        {
            plusOrMinus = "";
        }

        Console.WriteLine($"You got a {letter}{plusOrMinus}");

        if (letter == "A" || letter == "B" || letter == "C")
        {
            Console.WriteLine("Congratulations! You passed the class");
        }
        else
        {
            Console.WriteLine("Sorry, you did not pass this class. Don't worry! You will next time!");
        }

    }
}