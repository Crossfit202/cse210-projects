public class CPU : Character
{
    public string SelectRoom()
    {
        List<string> options = new List<string> {"w", "A", "S", "D"};

        Random random = new Random();
        int index = random.Next(options.Count);
        string randomString = options[index];
        return randomString;
    }
}