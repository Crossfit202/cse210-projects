public class Selector
{
    private List <string> _places = new List<string>();
   

    private string _exit = "Grand Entrance";
    

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

    public List<string> SelectRandomRooms()
    {
        Random random = new Random();
        List<string> randomRooms = new List<string>();

        for (int i = 0; i < 4; i++)
        {
            int index = random.Next(_places.Count);
            randomRooms.Add(_places[index]);
           
            //_places.RemoveAt(index);
        }

        return randomRooms;

        
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
        Console.Clear();
        Console.WriteLine($"{playerName}, you may now exit the building");
        Console.WriteLine();
        Console.WriteLine($"W. {_exit}");
        Console.ReadLine();
        Console.WriteLine("Congratulations! You have escaped the Chaser");
        Thread.Sleep(5000);
    }


}