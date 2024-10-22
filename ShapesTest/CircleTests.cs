using Shapes;

namespace ShapesTest;

[TestClass]
public class CircleTests
{
    [DataTestMethod]
    [DataRow(5, 5 * 5 * Math.PI * 2)]
    [DataRow(0, 0)]
    [DataRow(-5, (-5) * (-5) * Math.PI * 2)]
    public void CalculateArea_ShouldReturnCorrectArea(double r, double expected)
    {
        var circle = new Circle(r);
        var result = circle.CalculateArea();
        Assert.AreEqual(expected, result);
    }
}