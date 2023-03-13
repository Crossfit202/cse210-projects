using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment assignment1 = new Assignment("Samuel Bennett", "Multiplication"); 

        Console.Clear();
        Console.WriteLine(assignment1.GetSumary());

        Console.WriteLine();
        MathAssignment mathassignment1 = new MathAssignment("7.3", "8-19", "Roberto Rodriguez", "Fractions");
        Console.WriteLine(mathassignment1.GetHomeworkList());
        Console.WriteLine();
        Console.WriteLine(mathassignment1.GetSumary());

        Console.WriteLine();
        WritingAssignment writingassignment1 = new WritingAssignment("The Causes of Word War II", "Mary Waters", "European History");
        Console.WriteLine(writingassignment1.GetWritingInformation());

        Console.WriteLine();
        Console.WriteLine(writingassignment1.GetSumary());
    }
}