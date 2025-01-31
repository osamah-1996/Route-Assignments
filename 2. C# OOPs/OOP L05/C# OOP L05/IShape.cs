using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__OOP_L05
{

    namespace ShapeExample
    {
         public interface IShape
        {
            double Area { get; }
            void DisplayShapeInfo();
        }

         public interface ICircle : IShape
        {
            double Radius { get; set; }
        }

         public interface IRectangle : IShape
        {
            double Width { get; set; }
            double Height { get; set; }
        }
    }

}
