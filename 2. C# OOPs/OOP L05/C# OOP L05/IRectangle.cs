using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using C__OOP_L05.ShapeExample;

namespace C__OOP_L05
{
    public class Rectangle : IRectangle
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public Rectangle(double width, double height)
        {
            Width = width;
            Height = height;
        }

        public double Area => Width * Height;

        public void DisplayShapeInfo()
        {
            Console.WriteLine($"Shape: Rectangle\nWidth: {Width}\nHeight: {Height}\nArea: {Area:F2}\n");
        }
    }
}
