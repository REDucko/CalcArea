using System;
using System.Collections.Generic;
using System.Text;

namespace CalcArea.Objects
{
    public class Circle : Figure
    {
        public Circle(double radius)
        {
            if (radius <= 0)
                throw new ArgumentOutOfRangeException("Невозможно создать круг, значение радиуса должно быть положительным");

            _radius = radius;
            Name = "Круг";
        }

        private double _radius;

        public override double CalculateArea()
        {
            return Math.PI * Math.Pow(_radius, 2);
        }
    }
}
