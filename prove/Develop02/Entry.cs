class Entry
{
    public Entry(string date, string prompt, string response)
    {

    }
    public string _date;
    public string _prompt;
    public string _response;

    public void Display()
    {

        Console.WriteLine($"{_date} - Prompt: {_prompt}");
        Console.WriteLine(_response);
    
    }

    public string GetEntry()
    {
        return string.Format("{0}|{1}|{2}", _date, _prompt, _response);
    }
}