using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureSqr
{
    public class Circle : IFigure
    {
        double _radius;

        public Circle(double radius)
        {
            if (radius > 0)
            {
                _radius = radius;
            }
            else
                throw new ArgumentException();
        }

        public double CalcPerimeter()
        {
            return 2 * Math.PI * _radius;
        }

        public double CalcSquare()
        {
            return Math.PI * Math.Pow(_radius, 2);
        }
    }
}
