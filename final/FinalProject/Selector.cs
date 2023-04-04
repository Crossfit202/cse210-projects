public class Selector
{
    private List <string> _places = new List<string>();
    private List<string> _randomRooms = new List<string>();
   

    public void MakeList()
    {
        
        _places.Add("Living Room");
        _places.Add("Dining Room");
        _places.Add("Library");
        _places.Add("Home Theater");
        _places.Add("Wine Cellar");
        _places.Add("Game Room");
        _places.Add("Main Study");
        _places.Add("Master Bedroom");
        _places.Add("Guest Bedroom");
        _places.Add("Master Bathroom");
    }

    public List<string> SelectRandomRooms(int level)
    {

        
    
        switch(level)
        {
            case 1: // easy

            List<string> randomRooms = new List<string>();
            Random rng = new Random();
            int n = _places.Count;
            while (n >= 1)
            {
                n--;
                int k = rng.Next(n + 1);
                string value = _places[k];
                _places[k] = _places[n];
                _places[n] = value;
            }

            for (int i = 0; i < 4; i++)
            {
                string selectedItem = null;
                do
                {
                    int index = rng.Next(_places.Count);
                    selectedItem = _places[index];
                }
                while (randomRooms.Contains(selectedItem));

                
                randomRooms.Add(selectedItem);

                _randomRooms = randomRooms;
            }
            break;

            case 2: // medium

            List<string> randomRooms2 = new List<string>();
            Random rng2 = new Random();
            int n2 = _places.Count;
            while (n2 >= 1)
            {
                n2--;
                int k = rng2.Next(n2 + 1);
                string value = _places[k];
                _places[k] = _places[n2];
                _places[n2] = value;
            }

            for (int i = 0; i < 3; i++)
            {
                string selectedItem = null;
                do
                {
                    int index = rng2.Next(_places.Count);
                    selectedItem = _places[index];
                }
                while (randomRooms2.Contains(selectedItem));

                
                randomRooms2.Add(selectedItem);

                _randomRooms = randomRooms2;
            }
            break;

            case 3: // hard

            List<string> randomRooms3 = new List<string>();
            Random rng3 = new Random();
            int n3 = _places.Count;
            while (n3 >= 1)
            {
                n3--;
                int k = rng3.Next(n3 + 1);
                string value = _places[k];
                _places[k] = _places[n3];
                _places[n3] = value;
            }

            for (int i = 0; i < 2; i++)
            {
                string selectedItem = null;
                do
                {
                    int index = rng3.Next(_places.Count);
                    selectedItem = _places[index];
                }
                while (randomRooms3.Contains(selectedItem));

                
                randomRooms3.Add(selectedItem);

                _randomRooms = randomRooms3;
            }
            break;

            

        }
        
        

        return _randomRooms;

        
    }

    public void RemoveFromList(string stringToRemove)
    {
        if (_places.Contains(stringToRemove))
        {
            _places.Remove(stringToRemove);
        }
    }

    public void Exit(string playerName)
    {
        
    }

    public void Win(string playerName, string runnerOrChaser)
    {
        Console.Clear();

        switch(runnerOrChaser.ToLower())
        {
            case "chaser":
            Console.WriteLine($"Congratulations {playerName}! You caught the Runner and they did not escape the mansion.");
            break;

            case "runner":
            Console.WriteLine($"Congratulations {playerName}! You have escaped the Chaser and exited the mansion");
            break;
        }
        
    }

    public void Lose(string runnerOrChaser) 
    {
        switch(runnerOrChaser.ToLower())
        {
            case "chaser":
            Console.WriteLine($"You did not catch the Runner and they escaped the mansion :/");
            break;

            case "runner":
            Console.WriteLine($"You have been caught by the Chaser and did not escape the mansion :/");
            break;
        }
    }
}