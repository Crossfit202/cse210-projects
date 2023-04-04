public class Chaser : Character
{
    public override string RoomChoice(string playerName, List<string> list)
    {
        List<string> options = new List<string>{"W", "A", "S", "D"};
        int index = -1;
        Console.Clear();
        Console.WriteLine($"{playerName}, which room would you like to search for the Runner?");
        foreach (string room in list)
            {
                Console.WriteLine($" {options[index + 1]}. {room}");
                index = index + 1;
            } 
        
        string roomChoice = Console.ReadLine();
            
        return roomChoice;
    }
}