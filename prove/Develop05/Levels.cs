public class Levels
{
    private string _level;

    public string DetermineLevel(int points)
    {
        switch (points)
        {
            case < 1000:
            _level = "You are level 0: A Snail Symphony"; 
            break;
            
            case < 2000:
            _level = "You are level 1: A Drama Llama"; 
            break;

            case < 3000:
            _level = "You are level 2: A Pickel Pete"; 
            break;

            case < 4000:
            _level = "You are level 3: A Cactus Carnival"; 
            break;

            case < 5000:
            _level = "You are level 4: A Waffle of Wackiness"; 
            break;

            case < 6000:
            _level = "You are level 5: A Disco Duck"; 
            break;

            case < 7000:
            _level = "You are level 6: A Taco Tornado"; 
            break;

            case < 8000:
            _level = "You are level 7: A Mustache Mimicker"; 
            break;

            case < 9000:
            _level = "You are level 8: A Jellybean Jamboree"; 
            break;

            case < 10000:
            _level = "You are level 9: A Rhino Referee"; 
            break;

            case > 10000:
            _level = "You are level 10: Literall the best there ever is, was, or will be"; 
            break;
        }
        
        return _level;
    }
}
