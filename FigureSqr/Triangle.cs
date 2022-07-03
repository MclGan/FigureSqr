using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureSqr
{
    public class Triangle : IFigure
    {
        double _sideA;
        double _sideB;
        double _sideC;

        public Triangle(double sideA, double sideB, double sideC)
        {
            if ((sideA > 0 && sideB > 0 && sideC > 0) &&
                (sideA < (sideB + sideC) && (sideB < (sideA + sideC)) && (sideC < (sideA + sideB))))
            {
                _sideA = sideA;
                _sideB = sideB;
                _sideC = sideC;
            }
            else
                throw new ArgumentException();
        }

        public double CalcPerimeter()
        {
            return _sideA + _sideB + _sideC;
        }

        public double CalcSquare()
        {
            double p = CalcPerimeter() / 2;
            return Math.Sqrt(p * (p - _sideA) * (p - _sideB) * (p - _sideC));
        }

        public bool IsRightTriangle()
        {
            if (IsRightTriangle(_sideA, _sideB, _sideC) ||
                IsRightTriangle(_sideB, _sideA, _sideC) ||
                IsRightTriangle(_sideC, _sideA, _sideB))
            {
                return true;
            }
            else
                return false;
        }

        private bool IsRightTriangle(double hypotenuse, double cathetus1, double cathetus2)
        {
            return Math.Abs(Math.Pow(cathetus1, 2) + Math.Pow(cathetus2, 2) - Math.Pow(hypotenuse, 2)) < 0.0001;
        }
    }
}
