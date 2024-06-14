namespace AreaCalcLib;

public interface IShape
{
    bool isSpecial { get; }
    public double CalculateArea();
}