namespace lvl3.Models;

class Square
{
    public double X { get; }
    public double Y { get; }
    public double Side { get; }

    public Square(double x, double y, double side)
    {
        X = x;
        Y = y;
        Side = Math.Abs(side);
    }

    // Ключ (табл. 2.1, кол.4): Периметр
    public double Perimeter => 4 * Side;

    // Для 3 рівня (табл. 2.3, варіант 5): критерій видалення по площі
    public double Area => Side * Side;

    public override string ToString()
    {
        return $"Квадрат [X:{X:F1}, Y:{Y:F1}, Side:{Side:F2}, S:{Area:F2}, P:{Perimeter:F2}]";
    }
}