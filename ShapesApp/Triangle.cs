namespace Shapes;

public class Triangle : IShape
{
    private double A { get; set; }

    private double B { get; set; }

    private double C { get; set; }

    private const double Tolerance = 1e-6;

    private double HalfPerimeter;

    public Triangle(double A, double B, double C)
    {
        this.A = A;
        this.B = B;
        this.C = C;
    }

    public double CalculateArea()
    {
        if (IsRightTriangle(A, B, C))
        {
            return A * B / 2; // A и B считаются катетами, C — гипотенузой
        }
        else if (IsRightTriangle(B, C, A))
        {
            return B * C / 2; // B и C — катеты, A — гипотенуза
        }
        else if (IsRightTriangle(A, C, B))
        {
            return A * C / 2; // A и C — катеты, B — гипотенуза
        }
        else
        {
            HalfPerimeter = (A + B + C) / 2;
            return Math.Sqrt(HalfPerimeter * (HalfPerimeter - A) * (HalfPerimeter - B) * (HalfPerimeter - C));
        }
    }

    public static bool IsRightTriangle(double side1, double side2, double hypotenuse)
    {
        return Math.Abs(hypotenuse * hypotenuse - (side1 * side1 + side2 * side2)) < Tolerance;
    }
}