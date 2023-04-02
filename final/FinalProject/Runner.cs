public class Runner : Character 
{
    private int _lives;

    public void LoseLife()
    {
        _lives -= 1;
    }
}