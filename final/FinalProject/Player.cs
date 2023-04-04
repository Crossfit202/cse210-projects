public class Player
{
    protected string _name; 
    
    protected Character _character; 

    public void SetName()
    {
        Console.Write("What is your name? ");
        _name = Console.ReadLine();
    }

    public string GetName()
    {
        return _name;
    }

    public void SetCharacter(int playerCount, bool chosen, string role)
    {
        
        if (playerCount == 2 && chosen == false)
        {
            Console.Write("Would you like to be the Runner or the Chaser (R/C)? ");
            bool valid = false;

            while (valid != true)
            {
                switch (Console.ReadLine().ToLower())
            {
                case "r":
                _character = new Runner();
                Console.WriteLine("You have chosen to be the Runner");
                valid = true;
                break;
    
                case "c":
                _character = new Chaser();
                Console.WriteLine("You have chosen to be the Chaser");
                valid = true;
                break;
                
                default: 
                Console.WriteLine("That is not a valid role. \nPlease enter either \"R\" or \"C\"");
                valid = false;
                break;
            }
    
            }
            
        }

        else if (playerCount == 2 && chosen == true && role.ToLower() == "r")
        {
            _character = new Chaser();
            Console.WriteLine("Player 2. You are the Chaser");
        }

         else if (playerCount == 2 && chosen == true & role.ToLower() == "c")
        {
            _character = new Runner();
            Console.WriteLine("Player 2. You are the Runner");
        }

        else if (playerCount == 1)
        {
            Console.Write("Would you like to be the Runner or the Chaser (R/C)? ");
            bool valid = false;
        
            while (valid != true)
            {
                switch (Console.ReadLine().ToLower())
            {
                case "r":
                _character = new Runner();
                Console.WriteLine("You have chosen to be the Runner");
                valid = true;
                break;

                case "c":
                _character = new Chaser();
                Console.WriteLine("You have chosen to be the Chaser");
                valid = true;
                break;

                default: 
                Console.WriteLine("That is not a valid role. \nPlease enter either \"R\" or \"C\"");
                valid = false;
                break;
            }

            }

        }
        
        
    }

    public Character GetCharacter()
    {
        return _character;
    }
}