using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPTask
{
    abstract class Shape : IComparable<Shape>
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

    class Square : Shape
    {
        double _side;
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

    class Rectangle : Shape
    {
        double _width;
        double _height;

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

    class Triangle : Shape
    {
        double _base;
        double _height;

        public Triangle(double base_, double height)
        {
            _base = base_;
            _height = height;

            square = GetSquare();
        }

        public override double GetSquare()
        {
            return _base * _height;
        }
    }

    class Circle : Shape
    {
        double _radius;

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
    class Program
    {
        static void Main(string[] args)
        {
            var side = 3D;
            var width = 10D;
            var height = 4D;
            var base_ = 3D;
            var radius = 5D;
            var shapes = new List<Shape>{ new Square(side),
                                        new Rectangle(width, height),
                                        new Triangle(base_, height),
                                        new Circle(radius)};

            Console.Write(String.Join(" ", shapes));

            Console.WriteLine();

            shapes.Sort();

            Console.Write(String.Join(" ", shapes));

            Console.ReadKey();      
        }
    }
}
