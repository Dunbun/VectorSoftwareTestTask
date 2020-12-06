using System;

public abstract class Shape : IComparable<Shape>
{
    protected double square;
    public int CompareTo(Shape shape)
    {
        if (shape == null)
        {
            return 1;
        }

        return Comparer<double>.Default.Compare(this.square, shape.square);
    }

    public abstract double GetSquare();

    public override string ToString()
    {
        return this.GetType().Name + " -> " + square.ToString();
    }
}
