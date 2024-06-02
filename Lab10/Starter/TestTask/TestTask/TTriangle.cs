using System;

class TTriangle : Shape, IRotation
{
    TPoint p1, p2, p3;

    public TTriangle(TPoint p1, TPoint p2, TPoint p3)
    {
        this.p1 = p1;
        this.p2 = p2;
        this.p3 = p3;

        base.sNameShape = "Треугольник";
    }

    //--.
    (double sideLen1, double sideLen2, double sideLen3) getSideLength()
    {
        double sideLen1 = p1.Distance(p2);
        double sideLen2 = p2.Distance(p3);
        double sideLen3 = p3.Distance(p1);

        return (sideLen1, sideLen2, sideLen3);
    }

    //--.
    public override void Perimetr()
    {
        var resSlen = getSideLength();
        base.rValuePerimetr = resSlen.sideLen1 + resSlen.sideLen2 + resSlen.sideLen3;
    }

    //--.
    public override void Square()
    {
        var (a, b, c) = getSideLength();

        //--. полупериметр
        double p = (a + b + c) / 2;

        this.rValueSquare =  Math.Sqrt(p * (p - a) * (p - b) * (p - c));
    }

    //--.
    public bool Valid()
    {
        //--.
        var (side1Len, side2Len, side3Len) = getSideLength();

            if ((side1Len + side2Len) <= side3Len ||
                (side2Len + side3Len) <= side1Len ||
                (side3Len + side1Len) <= side2Len)
                return false;

            return true;
    }

    public int IAngle { get; set; }

    //--.
    public void RotationOperations()
    {
        Console.WriteLine("Поворот квадрата на угол {0}", IAngle);
    }

}