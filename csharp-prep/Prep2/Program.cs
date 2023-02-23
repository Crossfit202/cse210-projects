using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? (0-100) ");
        string gradePercent = Console.ReadLine();
        int percent = int.Parse(gradePercent);
        string grade = null;

        if (percent >= 90)
        {
            grade = "A";
            Console.WriteLine($"You got an {grade}");
        }
        else if (percent >= 80)
        {
            grade = "B";
            Console.WriteLine($"You got a {grade}");
        }
        else if (percent >= 70)
        {
            grade = "C";
            Console.WriteLine($"You got a {grade}");
        }
        else if (percent >= 60)
        {
            grade = "D";
            Console.WriteLine($"You got a {grade}");
        }
        else
        {
            grade = "F";
            Console.WriteLine($"You got a {grade}");
        }

        if (grade == "A" || grade == "B" || grade == "C")
        {
            Console.WriteLine("Congratulations! You passed the class");
        }
        else
        {
            Console.WriteLine("Sorry, you did not pass this class. Don't worry! You will next time!");
        }
    }
}