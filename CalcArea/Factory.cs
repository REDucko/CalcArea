using System;
using System.Collections.Generic;
using System.Text;

namespace CalcArea.Objects
{
    public enum FigureType { Circle, Triangle };

    public class Factory
    {
        public Figure CreateFigure(FigureType type, double size1, double size2 = 0, double size3 = 0)
        {
            switch (type)
            {
                case FigureType.Circle:
                    return CreateCircle(size1);
                case FigureType.Triangle:
                    return CreateTriangle(size1, size2, size3);
                default:
                    return null;
            }
        }

        private Figure CreateCircle(double radius)
        {
            return new Circle(radius);
        }

        private Figure CreateTriangle(double side1, double side2, double side3)
        {
            return new Triangle(side1, side2, side3);
        }
    }
}
