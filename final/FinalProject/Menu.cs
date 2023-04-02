public class Menu
{
    private List<string> _menuList = new List<string>();
    private int userInput = 0;
   

    public void CreateMenu()
    {
        _menuList.Add("Menu:");
        _menuList.Add(" 1. Play against the computer");
        _menuList.Add(" 2. Play against another person");
        _menuList.Add(" 3. Quit");
         
    }

    public int GetInput()
    {
        return userInput;
    }

    public void DisplayMenu()
    {
        Console.Clear();

        foreach (string i in _menuList)
        {
            Console.WriteLine(i);
            
        }

        Console.Write("\nPlease select an item from the menu (1-3) ");
            
        userInput = int.Parse(Console.ReadLine());
    }

    public void PrintMessage(string message)
    {
        Console.WriteLine();
        Console.WriteLine(message);
        Console.WriteLine("\nPress Enter to start");
        Console.ReadLine();
    }





}