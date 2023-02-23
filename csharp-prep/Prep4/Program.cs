using System;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        int num = -1;
        float runningTotal = 0;
        int biggestNumber = 0;
        

        while (num != 0)
        {
            // Get user input
            Console.Write("Enter a number: ");
            string input = Console.ReadLine();
            int number = int.Parse(input);
            
            //Keep list appending until 0 is entered 
            if (number != 0)
            {
                //Append to the list
                numbers.Add(number);
            
            }
            else 
            {
                num = 0;
            }
        }
        // For each number in the list, see if it's the biggest number and add it to the total. 
        foreach (int number in numbers)
        {
            if (number > biggestNumber)
            {
                biggestNumber = number;
            }
            runningTotal += number;
        }

        //Compute the average
        float average = runningTotal / numbers.Count;

        //Display Results
        Console.WriteLine($"The sum is: {runningTotal}");
        Console.WriteLine($"The Average is {average}");
        Console.WriteLine($"The largest number is {biggestNumber}");
    }
}