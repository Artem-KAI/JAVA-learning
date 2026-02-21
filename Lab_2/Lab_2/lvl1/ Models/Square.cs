using System;

namespace LabHash.Models;

public class Square
{
    public Point A, B, C, D;
    public double P; // ключ — периметр

    private static readonly Random Rand = new Random();

    public Square()
    {
        do
        {
            CreateSquare();
        }
        while (!Check());

        P = Perimeter();
    }

    private void CreateSquare()
    {
        A = new Point();

        double side = Rand.NextDouble() * 5 + 1;

        B = new Point { X = A.X + side, Y = A.Y };
        C = new Point { X = A.X + side, Y = A.Y + side };
        D = new Point { X = A.X, Y = A.Y + side };
    }

    private bool Check()
    {
        double ab = Side(A, B);
        double bc = Side(B, C);
        double cd = Side(C, D);
        double da = Side(D, A);

        return Math.Abs(ab - bc) < 0.0001 &&
               Math.Abs(bc - cd) < 0.0001 &&
               Math.Abs(cd - da) < 0.0001;
    }

    private double Side(Point p1, Point p2)
    {
        return Math.Sqrt(Math.Pow(p1.X - p2.X, 2) +
                         Math.Pow(p1.Y - p2.Y, 2));
    }

    public double Perimeter()
    {
        return 4 * Side(A, B);
    }

    public override string ToString()
    {
        return $"A{A} B{B} C{C} D{D}";
    }
}