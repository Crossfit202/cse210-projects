public class BodyFocusActivity : Activity
{
    
    List<string> _bodyParts = new List<string>();
    
    public BodyFocusActivity(string _activityName, string _description) : base(_activityName, _description)
    {

    }

    public void MakeBodyPartList()
    {
        _bodyParts.Add("face and neck");
        _bodyParts.Add("shoulders");
        _bodyParts.Add("chest and stomach");
        _bodyParts.Add("upper arms");
        _bodyParts.Add("forearms and hands");
        _bodyParts.Add("back");
        _bodyParts.Add("hips");
        _bodyParts.Add("thighs");
        _bodyParts.Add("calves");
        _bodyParts.Add("feet");
    }
    
    public void ListBodyParts()
    {
        Console.Clear();

        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(_duration);

        while (DateTime.Now < futureTime)
        {
            foreach (string part in _bodyParts)
            {
                MakeSpinner($"\nThink about your {part} and relax it. ", _duration / 10);  
                Console.WriteLine();
            } 
        } 
    }
}