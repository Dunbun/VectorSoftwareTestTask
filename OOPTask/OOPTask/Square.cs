using System;

public class Square : Shape
{
    private double _side;
    public Square(double side)
    {
        _side = side;
        square = GetSquare();
    }

    public override double GetSquare()
    {
        return _side * _side;
    }
}