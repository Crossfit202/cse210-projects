public class Circle : Shape 
{
    
    private double _radius;

    public Circle(string _color, double radius) : base(_color)
    {
        _radius = radius;
    }


    public override double GetArea()
    {
        return (Math.PI * (_radius * _radius));
    }
}