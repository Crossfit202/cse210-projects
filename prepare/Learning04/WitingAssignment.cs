public class WritingAssignment : Assignment
{
    private string _title; 

    public WritingAssignment(string title, string _name, string _topic) : base(_name, _topic)
    {
        _title = title;
    }

    public string GetWritingInformation()
    {
        return string.Format("{0} - {1} \n{2} by {3}", _studentName, _topic, _title, _studentName);
    }
}