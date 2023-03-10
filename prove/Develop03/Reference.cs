class Reference
{
    private string _book; 
    private string _chapter;
    private string _verse;
    private string _endVerse;

    
    public Reference()
    {

    }
    public Reference(string book, string chapter, string verse)
    {
        _book = book; 
        _chapter = chapter; 
        _verse = verse;
    }

    public Reference(string book, string chapter, string verse, string endVerse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
        _endVerse = endVerse;
    }
    
    public string toSingleVerse()
    {
        return string.Format("{0} {1}:{2}", _book, _chapter, _verse);
    }

    public string toMultiVerse()
    {
        return string.Format("{0} {1}:{2}-{3}", _book, _chapter, _verse, _endVerse);
    }

    public void promptReference()
    {
        Console.WriteLine("What is the book?");
        _book = Console.ReadLine();

        Console.WriteLine("What is the chapter?");
        _chapter = Console.ReadLine();

        Console.WriteLine("What is the verse?");
        _verse = Console.ReadLine();


        
        

    }


}