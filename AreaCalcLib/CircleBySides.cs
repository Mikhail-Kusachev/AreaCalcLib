namespace AreaCalcLib;

public class Circle : IShape
{
    public bool isSpecial { get; }

    private double _radius;

    public Circle(double[] sides)
    {
        _radius = sides[0];
        isSpecial = false;
    }

    public double CalculateArea()
    {
        return Math.PI * _radius * _radius;
    }
}