class Word
{
    private Scripture _scripture;
    private List<string> _scriptureText;

    public Word(Scripture scripture)
    {
        _scripture = scripture;
        _scriptureText = new List<string>();
        makeList();
    }

    private void makeList()
    {
        _scriptureText = _scripture.scriptureString().Split(' ').ToList();
    }

    public void hide()
    {
        int totalWordsRemoved = 0;
        int wordsToHide = new Random().Next(2,4);
        

        do
        {
            int index = new Random().Next(0, _scriptureText.Count());
            if (_scriptureText[index].Contains('_') == false)
            {
                _scriptureText[index] = new string('_', _scriptureText[index].Length);
                totalWordsRemoved++;
            }
        } while (totalWordsRemoved != wordsToHide || IsCompletelyHidden() == false);
    }

    public string toString()
    {
        return string.Join(' ', _scriptureText);
    }

    public bool IsCompletelyHidden()
    {
        bool value = false;

        foreach (string word in _scriptureText)
        {
            if (word.Contains('_') == false)
            {
                value = true;
                break;
            }
        }
        return value;
    }
}