using System;
using CalcArea.Objects;

namespace Run
{
    class Program
    {
        static void Main(string[] args)
        {
            var factory = new Factory();

            var myCircle = factory.CreateFigure(FigureType.Circle, 2);
            Console.WriteLine("{0}. Площадь {1}", myCircle.Name, myCircle.CalculateArea());

            var myTriangle = factory.CreateFigure(FigureType.Triangle, 5, 4, 3);
            Console.WriteLine("{0}. Площадь {1}", myTriangle.Name, myTriangle.CalculateArea());
        }
    }
}
