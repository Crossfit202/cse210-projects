class Scripture
{
    private string _scriptureText;

    private Reference _reference;

    public Scripture()
    {

    }
    public Scripture(Reference reference, string scriptureText)
    {
        _scriptureText = scriptureText;
        _reference = reference;
    }

    public void promptScripture()
    {
        Console.WriteLine("Please enter the scripture text that you would like to memorize");
        string input = Console.ReadLine(); 
        _scriptureText = input;
    }
    public string scriptureString()
    {
        return string.Format("\"{0}\"", _scriptureText);
    }
}