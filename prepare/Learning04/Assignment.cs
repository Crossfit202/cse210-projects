public class Assignment
{
    protected string _studentName;
    protected string _topic; 

    
    public Assignment()
    {
        
    }
    public Assignment(string name, string topic)
    {
        _studentName = name; 
        _topic = topic;
    }
    public string GetSumary()
    {
        return string.Format("{0} - {1}", _studentName, _topic);
    }
}