public class MathAssignment : Assignment
{
    private string _textbookSection;
    private string _problems;

    public MathAssignment(string textbookSection, string problems, string _name, string _topic) : base(_name, _topic)
    {
        _textbookSection = textbookSection; 
        _problems = problems;
    }
    
    public string GetHomeworkList()
    {
        return string.Format("{0} - {1} \nSection {2} Problems {3}", _studentName, _topic, _textbookSection, _problems);
    }
}