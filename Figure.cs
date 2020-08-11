using System;

namespace AreaCalculator
{
    public abstract class Figure : IFigure
    {
        public double Area { get; set; }

        public abstract double GetArea();

    }
}
