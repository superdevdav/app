namespace Shapes;

public class Circle : IShape
{
    private double Radius { get; set; }

    public Circle(double Radius)
    {
        this.Radius = Radius;
    }

    public double CalculateArea()
    {
        return 2 * Math.PI * Radius * Radius;
    }
}