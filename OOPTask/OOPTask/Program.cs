using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPTask
{
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
