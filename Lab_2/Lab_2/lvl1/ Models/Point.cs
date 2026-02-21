namespace LabHash.Models;

public class Point
{
    public double X;
    public double Y;

    private static readonly Random Rand = new Random();

    public Point()
    {
        X = Rand.NextDouble() * 10;
        Y = Rand.NextDouble() * 10;
    }

    public override string ToString()
    {
        return $"({X:F2}; {Y:F2})";
    }
}