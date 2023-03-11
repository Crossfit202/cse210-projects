class Word
{
    
  

    private string _word; 

    

    public Word(string word)
    {
        _word = word;
        

    }

    public Word()
    {

    }

    public string getWord()
    {
        return _word.ToString();
    }

    public void hide()
    {
     _word = new string('_', _word.Length);
    }
    
    public bool isHidden()
    {
        bool value = false;

        if (_word.Contains('_'))
        {
            value = true;
        }

        return value;
    }
}