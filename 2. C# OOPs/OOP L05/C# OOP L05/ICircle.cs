using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using C__OOP_L05.ShapeExample;

namespace C__OOP_L05
{
    public class Circle : ICircle
    {
        public double Radius { get; set; }

        public Circle(double radius)
        {
            Radius = radius;
        }

        public double Area => Math.PI * Radius * Radius;

        public void DisplayShapeInfo()
        {
            Console.WriteLine($"Shape: Circle\nRadius: {Radius}\nArea: {Area:F2}\n");
        }
    }
}
