namespace AreaCalcLib;

public class Triangle : IShape
{
    private double _sideA;
    private double _sideB;
    private double _sideC;
    private double _semiperimeter;
    public bool isSpecial { get; }
    
    public Triangle(double[] sides)
    {
        CheckInput(sides);
        _sideA = sides[0];
        _sideB = sides[1];
        _sideC = sides[2];
        _semiperimeter = (_sideA + _sideB + _sideC) / 2;
        isSpecial = IsRight();
    }

    public double CalculateArea()
    {
        return Math.Sqrt(_semiperimeter * (_semiperimeter - _sideA) *
                         (_semiperimeter - _sideB) * (_semiperimeter - _sideC));
    }
    
    private void CheckInput(double[] sides)
    {
        double sideA = sides[0];
        double sideB = sides[1];
        double sideC = sides[2];
        if (sideA >= sideB + sideC || sideB >= sideC + sideA || sideC >= sideA + sideB)
            throw new ArgumentException($"Triangle with sides {sideA}, {sideB}, {sideC} is impossible");
    }
    
    private bool IsRight()
    {
        return Tools.NearlyEqual(_sideA * _sideA + _sideB * _sideB, _sideC * _sideC, 1E-6) ||
               Tools.NearlyEqual(_sideA * _sideA + _sideC * _sideC, _sideB * _sideB, 1E-6) ||
               Tools.NearlyEqual(_sideB * _sideB + _sideC * _sideC, _sideA * _sideA, 1E-6);
    }
}