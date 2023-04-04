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
}