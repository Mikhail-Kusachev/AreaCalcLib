namespace AreaCalcLib;

//clumsy and useless in real cases but fully meets the requirements 
//in real cases better way is to use abstract class 
public class ShapeFactory
{
    //public IShape Create(vector2[] points)
    //public IShape Create(string[] functions)
    public IShape Create(double[] sides)
    {
        if (!Tools.IsNumberArrayAllPositive(sides))
            throw new ArgumentException("Side or radius should be positive number");
        
        switch (sides.Length)
        {
            case 1:
                return new Circle(sides);
            case 3:
                return new Triangle(sides);
            default:
                throw new ArgumentException(
                    "only 1 argument for circle radius and 3 arguments for triangle sides so far");
        }
    }
}