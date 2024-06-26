namespace AreaCalcLib.Tests;

public class TriangleTests
{
    [Test]
    public void Triangle_CalculateArea_3_4_5_return_6()
    {
        var shapeFactory = new ShapeFactory();
        var shape = shapeFactory.Create(new double[] { 3, 4, 5 });
        double expected = 6;
        double actual = shape.CalculateArea();
        Assert.AreEqual(expected, actual);
    }

    [Test]
    public void Triangle_ZeroSide()
    {
        var shapeFactory = new ShapeFactory();
        Assert.That(() => shapeFactory.Create(new double[] { 5, 12, 0 }),
            Throws.Exception.TypeOf<ArgumentException>());
    }

    [Test]
    public void Triangle_ImpossibleSideEnumeration()
    {
        var shapeFactory = new ShapeFactory();
        Assert.That(() => shapeFactory.Create(new double[] { 1, 1, 2 }),
            Throws.Exception.TypeOf<ArgumentException>());
    }
    
    [Test]
    public void Triangle_NegativeSide()
    {
        var shapeFactory = new ShapeFactory();
        Assert.That(() => shapeFactory.Create(new double[] { 5, -12, 13 }),
            Throws.Exception.TypeOf<ArgumentException>());
    }

    [Test]
    public void Triangle_IsRight_3_4_5_return_true()
    {
        var shapeFactory = new ShapeFactory();
        var shape = shapeFactory.Create(new double[] { 3.0, 4.0, 5.0 });
        bool expected = true;
        bool actual = shape.isSpecial;
        Assert.AreEqual(expected, actual);
    }

    [Test]
    public void Triangle_IsRight_2_3_4_return_false()
    {
        var shapeFactory = new ShapeFactory();
        var shape = shapeFactory.Create(new double[] { 2, 3.111, 4.255 });
        bool expected = false;
        bool actual = shape.isSpecial;
        Assert.AreEqual(expected, actual);
    }
}