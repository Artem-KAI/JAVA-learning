namespace lvl1.Models;

class Square
{
    public double X { get; private set; }
    public double Y { get; private set; }
    public double Side { get; private set; }

    public Square(double x, double y, double side)
    {
        X = x;
        Y = y;
        Side = Math.Abs(side);
    }

    public double GetPerimeter() => 4 * Side;
    public double GetArea() => Side * Side;

    public override string ToString()
    {
        return $"Квадрат [Поз: ({X:F1}; {Y:F1}), Сторона: {Side:F2}, Площа: {GetArea():F2}, Перим: {GetPerimeter():F2}]";
    }
}