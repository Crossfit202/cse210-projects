public class ListingActivity : Activity
{
    public ListingActivity(string _activityName, string _description) : base(_activityName, _description)
    {

    }

    private List<string> _prompts = new List<string>();

    private List<string> _userInput = new List<string>();



    public void MakeListingPrompts()
    {
        _prompts.Add("Who are people that you appreciate?");
        _prompts.Add("What are personal strengths of yours?");
        _prompts.Add("Who are people that you have helped this week?");
        _prompts.Add("When have you felt the Holy Ghost this month?");
        _prompts.Add("Who are some of your personal heroes?");
    }

    public void DisplayRandomListingPrompt()
    {
        Random r = new Random();
        int index = r.Next(_prompts.Count);
        string randomPrompt = _prompts[index];

        Console.WriteLine("List as many responses as you can to the following prompt:");
        Console.WriteLine($"--- {randomPrompt} ---");
        Console.Write("You may begin in: ");
        MakeCountdown(5);
    }

    public void UserWrites()
    {
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(_duration);
        int count = 0;

        while (DateTime.Now < futureTime)
        {
            Console.WriteLine();
            Console.Write("> ");
            string input = Console.ReadLine();
            _userInput.Add(input);
            count ++;
        }
        
        Console.Write($"\nYou listed {count} items");
    }

}