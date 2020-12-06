using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Triangle : Shape
{
    private double _base;
    private double _height;

    public Triangle(double @base, double height)
    {
        _base = @base;
        _height = height;

        square = GetSquare();
    }

    public override double GetSquare()
    {
        return _base * _height;
    }
}