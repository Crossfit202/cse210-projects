using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();

        string name = PromptUserName();

        int favoriteNum = PromptUserNumber();

        int squareNum = SquareNumber(favoriteNum);

        DisplayResult(name, squareNum);
    }
    
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the program!");
    }

    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        string response = Console.ReadLine();
        return response;
    }

    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        string response = Console.ReadLine();
        int number = int.Parse(response);
        return number;
    }

    static int SquareNumber(int num)
    {
        int squared = num * num;
        return squared;
    }

    static void DisplayResult(string name, int squareNum)
    {
        Console.WriteLine($"{name}, the square of your favorite number is {squareNum}");
    }




}
