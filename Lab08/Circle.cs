using System.Runtime.CompilerServices;

namespace Lab08;

public class Circle : AbstractGraphic2D
{
    public override decimal LowerBoundX => CenterX - Radius;

    public override decimal UpperBoundX => CenterX + Radius;

    public override decimal LowerBoundY => CenterY - Radius;

    public override decimal UpperBoundY => CenterY + Radius;

    public decimal CenterX;
    public decimal CenterY;
    public decimal Radius;


    public Circle(decimal x, decimal y, decimal radius)
    {
        CenterX = x;
        CenterY = y;
        Radius = radius;

    }

    public override bool ContainsPoint(decimal x, decimal y)
    {

        decimal widthFromCenter = Math.Abs(x - CenterX);
        decimal heightFromCenter = Math.Abs( y - CenterY);

        if (x > UpperBoundX || x < LowerBoundX) return false;
        else if (y > UpperBoundY || y < LowerBoundY) return false;
        else if ((widthFromCenter * widthFromCenter) + (heightFromCenter * heightFromCenter) > (Radius * Radius)) return false;
        else return true;
    }
}