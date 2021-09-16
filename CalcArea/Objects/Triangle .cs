using System;
using System.Collections.Generic;
using System.Text;

namespace CalcArea.Objects
{
    public class Triangle : Figure
    {
        public Triangle(double side1, double side2, double side3)
        {
            if(side1 + side2 <= side3)
                throw new ArgumentOutOfRangeException("Невозможно создать треугольник с заданными сторонами");

            if (side2 + side3 <= side1)
                throw new ArgumentOutOfRangeException("Невозможно создать треугольник с заданными сторонами");

            _side1 = side1;
            _side2 = side2;
            _side3 = side3;
            Name = "Треугольник";
        }

        private double _side1;
        private double _side2;
        private double _side3;

        public override double CalculateArea()
        {
            var halfperimeter = (_side1 + _side2 + _side3) / 2;

            return Math.Sqrt(halfperimeter * (halfperimeter - _side1) * (halfperimeter - _side2) * (halfperimeter - _side3));
        }
    }
}
