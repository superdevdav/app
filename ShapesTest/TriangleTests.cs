using Shapes;

namespace ShapesTest;

[TestClass]
public class TriangleTests
{
    [DataTestMethod]
    [DataRow(3, 4, 5, 6)]
    [DataRow(6, 8, 10, 24)]
    [DataRow(7, 24, 25, 84)]
    [DataRow(5, 12, 13, 30)]
    public void CalculateArea_Positive(double a, double b, double c, double expected)
    {
        var triangle = new Triangle(a, b, c);
        var result = triangle.CalculateArea();
        Assert.AreEqual(expected, result);
    }
}