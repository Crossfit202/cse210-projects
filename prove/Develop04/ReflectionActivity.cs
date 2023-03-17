public class ReflectionActivity : Activity
{
    public ReflectionActivity(string _activityName, string _description) : base(_activityName, _description)
    {

    }

    private List<string> _prompts = new List<string>();
    private List<string> _reflectQuestions = new List<string>();


    public void MakeReflectionPrompts()
    {   
       
        _prompts.Add("Think of a time when you stood up for someone else");
        _prompts.Add("Think of a time when you did something really difficult");
        _prompts.Add("Think of a time when you helped someone in need");
        _prompts.Add("Think of a time when you did something truly selfless");

    }

    public void MakeReflectionQuestions()
    {
        _reflectQuestions.Add("Why was this experience meaningful to you? ");
        _reflectQuestions.Add("Have you ever done anything like this before? ");
        _reflectQuestions.Add("How did you get started? ");
        _reflectQuestions.Add("How did you feel when it was complete? ");
        _reflectQuestions.Add("What made this time different than other times when you were not as successful? ");
        _reflectQuestions.Add("What is your favorite thing about this experience? ");
        _reflectQuestions.Add("What could you learn from this experience that applies to other situations? ");
        _reflectQuestions.Add("What did you learn about yourself through this experience? ");
        _reflectQuestions.Add("How can you keep this experience in mind in the future? ");
    }
    
    public void DisplayRandomQuestion()
    {
        Console.Clear();
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(_duration);
        
        while (DateTime.Now < futureTime)
        {
            Random r = new Random();
            int index = r.Next(_reflectQuestions.Count);
            string randomQuestion = _reflectQuestions[index];

            Console.WriteLine();
            MakeSpinner($"> {randomQuestion}", 10);
            Console.WriteLine();
        }
        
    }
    
    public void DisplayRandomReflectionPrompt()
    {
        Random r = new Random();
        int index = r.Next(_prompts.Count);
        string randomPrompt = _prompts[index];
        
        Console.WriteLine("\nConsider the following prompt:");
        Console.WriteLine($"\n---{randomPrompt}---");

        Console.WriteLine("\nWhen you have something in mind, press enter to continue.");
        Console.ReadLine();

        Console.WriteLine("\nNow ponder on each of the following questions and apply them to this experience");
        Console.Write("You may being in: ");
        MakeCountdown(5);
        
    }

}

    