class Scripture
{
    private string _scriptureText;

    private Reference _reference;

    private bool _isCompletelyHidden = false;

    private int _totalWordsHidden = 0;

    private int _wordsToHide;

    List<Word> _words = new List<Word>();


    public Scripture()
    {

    }
    public Scripture(Reference reference, string scriptureText, int wordsToHide)
    {
        _scriptureText = scriptureText;
        _reference = reference;
        _wordsToHide = wordsToHide;
    }

    public void promptScriptureAndWords()
    {
        Console.WriteLine("Please enter the scripture text that you would like to memorize");
        string input = Console.ReadLine(); 
        _scriptureText = input;

        Console.WriteLine("How many words would you like to hide each round?");
        string I = Console.ReadLine();
        

        _wordsToHide = int.Parse(I);
    }
    public void makeList()
    {
        
        string[] splitList = _scriptureText.Split(" ");
        
        foreach (string word in splitList)
        {
            Word w = new Word(word);
            _words.Add(w);
        }
        
    }

    public void hideRandomWords()
    {
        int timesHidden = 0;

        if (_totalWordsHidden < _words.Count() - _wordsToHide)
        {
            
            while (timesHidden != _wordsToHide)
            {
                
                var r  = new Random();
                int index = r.Next(0, _words.Count());
                Word randWord = _words[index];

                if (randWord.isHidden() == false)
                {
                    randWord.hide();
                    _totalWordsHidden ++;
                    timesHidden ++;

                }
            }
        }
        
        else if (_totalWordsHidden >= _words.Count() - _wordsToHide && _totalWordsHidden != _words.Count())
        {
            foreach (Word w in _words)
            {
                if (w.isHidden() == false)
                {
                    w.hide();
                    _totalWordsHidden ++;
                }
            }
         
        }
        
        else
        {
            _isCompletelyHidden = true;
        }
    }

    

    public void displayScripture()
    {   
        var result = string.Empty;
        foreach (Word w in _words)
        {
            result += ($" {w.getWord()}");
        }
        string display = string.Format("{0} {1}", _reference.toSingleVerse(), result);

        Console.WriteLine(display);
    }

    public bool IsCompletelyHidden()
    {
        return _isCompletelyHidden;
    }


}