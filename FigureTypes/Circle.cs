using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaCalculator.FigureTypes
{
    public class Circle : Figure, IFigure
    {
        public double Radius { get; set; }

        public Circle(double radius)
        {
            Radius = radius;
        }

        public override double GetArea()
        {
            this.Area = Math.PI * Math.Pow(Radius, 2);
            return Area;
        }
    }
}
