class PromptGenerator
{
    public List<string> _prompts = new List<string>();
    static Random rnd = new Random();

    public string RandomPrompt()
    {
        DayOfWeek day = DateTime.Today.DayOfWeek;
        
        if (day == DayOfWeek.Sunday)
        {
            _prompts.Add("Who spoke in Sacrament today?");
            _prompts.Add("What did you learn that you didn't know before?");
            _prompts.Add("What was the topic in Come, Follow Me?");
            _prompts.Add("Was there a special musical number in sacrament?");
            _prompts.Add("Who did you have the longest conversation with at Church? What was it about?");

            return _prompts[rnd.Next(_prompts.Count)];
        }
        
        else
        {
            _prompts.Add("What was the first thing you did when you woke up today?");
            _prompts.Add("What was the strongest emotion you felt today?");
            _prompts.Add("What was the funniest thing Rio did today?");
            _prompts.Add("What assignment were you most proud of completing today?");
            _prompts.Add("What songs did you play today?");
            _prompts.Add("Did you leave the house today? Where did you go?");
            return _prompts[rnd.Next(_prompts.Count)];
        }
        
    }

    
}