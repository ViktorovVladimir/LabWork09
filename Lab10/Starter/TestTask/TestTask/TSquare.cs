using System;

class TSquare : Shape, IRotation
{
    double rSideLen;

    public TSquare(double sideLen)
    {
        this.rSideLen = sideLen;

        //--.
        base.sNameShape = "Квадрат";
    }

    //--.
    public override void Perimetr()
    {
        base.rValuePerimetr = 4 * rSideLen;
    }

    //--.
    public override void Square()
    {
        base.rValueSquare = rSideLen * rSideLen;
    }

    public int IAngle { get; set; }

    //--.
    public void RotationOperations()
    {
        Console.WriteLine("Поворот квадрата на угол {0}", IAngle);
    }


}