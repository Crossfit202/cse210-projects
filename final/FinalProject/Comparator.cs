public class Comparator
{
    public bool Compare(string choice, string choice2)
    {
        bool trueOrFalse = false;
        if (choice.ToLower() == choice2.ToLower())
        {
            trueOrFalse = true;
        }

        return trueOrFalse;

    }

    public bool CompareTwoPlayer(string choice, string choice2)
    {
        bool trueOrFalse = false;

        if (choice.ToLower() == "w" && choice2.ToLower() == "i")
        {
            trueOrFalse = true;
        }

        else if (choice.ToLower() == "a" && choice2.ToLower() == "j")
        {
            trueOrFalse = true;
        }

        if (choice.ToLower() == "s" && choice2.ToLower() == "k")
        {
            trueOrFalse = true;
        }

        if (choice.ToLower() == "d" && choice2.ToLower() == "l")
        {
            trueOrFalse = true;
        }
        
        return trueOrFalse;
    }
}