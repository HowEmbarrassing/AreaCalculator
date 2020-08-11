using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaCalculator.FigureTypes
{
    public class Triangle : Figure, IFigure
    {
        public double SideA { get; set; }
        public double SideB { get; set; }
        public double SideC { get; set; }
        public bool IsRight { get; set; }

        public Triangle(double sideA, double sideB, double sideC)
        {
            SideA = sideA;
            SideB = sideB;
            SideC = sideC;
            IsRight = IsRightTriangle(SideA, SideB, SideC);
        }

        public override double GetArea()
        {
            List<double> sides = new List<double> { SideA, SideB, SideC };
            if (NumberOfEqualMaxSides(sides) == 3)
            {
                this.Area = (Math.Sqrt(3) * Math.Pow(SideC, 2)) / 4;
            }
            else
            {
                double p = (SideA + SideB + SideC) / 2;
                this.Area = Math.Sqrt(p * (p - SideA) * (p - SideB) * (p - SideC));
            }
            return this.Area;
        }

        public int NumberOfEqualMaxSides(List<double> sides)
        {
            List<double> maxSides = sides.Where(x => x == sides.Max()).ToList();
            return maxSides.Count;
        }

        public bool IsRightTriangle(double _sideA, double _sideB, double _sideC)
        {
            List<double> sides = new List<double>{_sideA, _sideB, _sideC};
            if (NumberOfEqualMaxSides(sides) > 1)
            {
                return false;
            }

            double maxVal = sides.Max();
            Console.WriteLine("Max value is " + maxVal);
            List<double> catheti = sides.Where(x => x < maxVal).ToList();

            double sumOfCatheti = Math.Pow(catheti[0], 2) + Math.Pow(catheti[1], 2);

            if (sumOfCatheti == Math.Pow(maxVal, 2))
            {
                return true;
            }

            else
            {
                return false;
            }
        }
    }
}
