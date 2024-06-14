namespace AreaCalcLib;

public class Tools
{
    public static bool NearlyEqual(double a, double b, double epsilon)
    {
        const double MinNormal = 2.2250738585072014E-308d;
        double absA = Math.Abs(a);
        double absB = Math.Abs(b);
        double diff = Math.Abs(a - b);

        if (a.Equals(b))
            return true; 
        else if (a == 0 || b == 0 || absA + absB < MinNormal) 
            return diff < (epsilon * MinNormal);
        else
            return diff / (absA + absB) < epsilon;
    }
    
    public static bool IsNumberArrayAllPositive(double[] array)
    {
        bool result = true; 
        foreach (var number in array)
            if (number <= 0)
                result = false;
        return result;
    }
}