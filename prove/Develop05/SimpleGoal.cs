public class SimpleGoal : Goal 
{
    
    public SimpleGoal()
    {

    }

    public SimpleGoal(string _goal, string _description, int _pointValue, bool _completed) : base(_goal, _description, _pointValue, _completed)
    {
        
    }
    

    public override string Format()
    {
        return string.Format("Simple:{0}|{1}|{2}|{3}", _goal, _description, _pointValue, _completed);
    }

 
}