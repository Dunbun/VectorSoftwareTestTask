using System;

public class Circle : Shape
{
    private double _radius;

    public Circle(double radius)
    {
        _radius = radius;

        square = GetSquare();
    }

    public override double GetSquare()
    {
        return _radius * Math.PI;
    }
}
