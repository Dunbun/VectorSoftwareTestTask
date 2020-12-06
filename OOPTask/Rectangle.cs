using System;

public class Rectangle : Shape
{
    private double _width;
    private double _height;

    public Rectangle(double width, double height)
    {
        _width = width;
        _height = height;

        square = GetSquare();
    }

    public override double GetSquare()
    {
        return _width * _height;
    }
}
