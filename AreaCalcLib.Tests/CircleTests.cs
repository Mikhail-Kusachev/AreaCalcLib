namespace AreaCalcLib.Tests;

public class CircleTests
{
    [Test]
    public void Circle_ZeroSide()
    {
        var shapeFactory = new ShapeFactory();
        Assert.That(() => shapeFactory.Create(new double[] { 0 }),
            Throws.Exception.TypeOf<ArgumentException>());
    }

    [Test]
    public void Circle_NegativeSide()
    {
        var shapeFactory = new ShapeFactory();
        Assert.That(() => shapeFactory.Create(new double[] { -12.55 }),
            Throws.Exception.TypeOf<ArgumentException>());
    }

    [Test]
    public void Circle_CalculateArea_Circle_1_return_pi()
    {
        var shapeFactory = new ShapeFactory();
        var shape = shapeFactory.Create(new double[] { 1 });
        double expected = Math.PI;
        double actual = shape.CalculateArea();
        Assert.AreEqual(expected, actual);
    }

    [Test]
    public void WrongArgumentsNumber()
    {
        var shapeFactory = new ShapeFactory();
        Assert.That(() => shapeFactory.Create(new double[] { 1, 1 }),
            Throws.Exception.TypeOf<ArgumentException>());
    }
}