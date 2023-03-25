public class EternalGoal : Goal
{
    
    public EternalGoal()
    {

    }

    public EternalGoal(string _goal, string _description, int _pointValue, bool _completed) : base(_goal, _description, _pointValue, _completed)
    {
        
    }
    
    public override string Format()
    {
        return string.Format("Eternal:{0}|{1}|{2}|{3}", _goal, _description, _pointValue, _completed);
    }

    public override string Completed(string yesOrNo)
    {
        _completed = false;
        _checkBox = "[ ]";

        return _checkBox;    
        
    }
 
    
}