namespace lvl2.Models;

using System;

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

    // Ключ (табл. 2.1, кол.4): Периметр
    public double GetPerimeter() => 4 * Side;
    public double GetArea() => Side * Side;

    public override string ToString()
    {
        return $"Квадрат [X:{X:F1}, Y:{Y:F1}, Side:{Side:F2}, S:{GetArea():F2}]";
    }
}