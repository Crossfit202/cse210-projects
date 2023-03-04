class Journal
{
    public List<Entry> _entries = new List<Entry>();


    public void DisplayEntries()
    {
        foreach (Entry entry in _entries)
        {
            entry.Display();
        }
    }

    public void MakeNewEntry()
    {
        Entry entry = new Entry("", "", "");
                    DateTime now = DateTime.Now;
                    entry._date = now.Date.ToString("D");
                    
                    PromptGenerator p = new PromptGenerator();
                    entry._prompt = p.RandomPrompt();
                    Console.WriteLine($"\n{entry._prompt}");

                    string response = Console.ReadLine();
                    entry._response = response;

                    _entries.Add(entry);
    }
    
    public void SaveToCSV()
    {
        List<string> records = new List<string>();
        foreach (Entry entry in _entries)
        {
            records.Add(entry.GetEntry());
        }
        Console.WriteLine("Name of file to save?");
        string _fileName = Console.ReadLine();

        File.WriteAllLines(_fileName, records);
    }
    
    public void LoadFromCSV()
    {
        Console.WriteLine("Name of file to load?");
        string _fileName = Console.ReadLine();

        List<string> records = System.IO.File.ReadAllLines(_fileName).ToList();
        foreach (string record in records)
        {
            string[] splitString = record.Split ("|");
            Entry entry = new Entry(splitString[0], splitString[1], splitString[2]);
            entry._date = splitString[0];
            entry._prompt = splitString[1];
            entry._response = splitString[2];
            _entries.Add(entry);
        }
    }

}