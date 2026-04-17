using System.Runtime.CompilerServices;

namespace Lab08;

public class Rectangle : AbstractGraphic2D
{
    public override decimal LowerBoundX => Left;

    public override decimal UpperBoundX => Left + Width;

    public override decimal LowerBoundY => Top;

    public override decimal UpperBoundY => Top + Height;

    public decimal Left;
    public decimal Top;
    public decimal Height;
    public decimal Width;

    public Rectangle(decimal _left, decimal _top, decimal width, decimal height)
    {
        Left = _left;
        Top = _top;
        Width = width;
        Height = height;
    }

    public override bool ContainsPoint(decimal x, decimal y)
    {
        if (x < Left || x > Left + Width) return false;
        else if (y < Top || y > Top + Height) return false;
        else return true;
    }
}