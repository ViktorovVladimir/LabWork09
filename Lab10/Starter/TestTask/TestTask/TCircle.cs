using System;


class TCircle : Shape
{
    double rRadius;

    public TCircle(double radius)
    {
        this.rRadius = radius;
        //--.
        base.sNameShape = "Окружность";
    }

    //--.
    public override void Perimetr()
    {
        base.rValuePerimetr = 2 * Math.PI + rRadius;
    }

    //--.
    public override void Square()
    {
        base.rValueSquare = Math.PI * rRadius * rRadius;
    }

    //--. метод Show

}