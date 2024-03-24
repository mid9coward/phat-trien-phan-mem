public class Triangle
{
    private double baseLength;
    private double height;

    public Triangle(double baseLength, double height)
    {
        this.baseLength = baseLength;
        this.height = height;
    }

    public double CalculateArea()
    {
        return 0.5 * baseLength * height;
    }
}

