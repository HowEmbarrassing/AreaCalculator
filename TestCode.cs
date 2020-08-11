using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace AreaCalculator.Tests
{

    // Unit-tests for Figure class
    [Fact]
    public void CalculateCircleFigureArea()
    {
        Figure sut = new Circle(15);
        double area = sut.GetArea();
        Assert.Equal(706.858, area, 3);
        Assert.Equal(706.858, sut.Area, 3);
    }

    [Fact]
    public void CalculateTriangleFigureArea()
    {
        Figure sut = new Triangle(3, 5, 6);
        double area = sut.GetArea();
        Assert.Equal(7.483, area, 3);
        Assert.Equal(7.483, sut.Area, 3);
    }

    // Unit-tests for Circle class

    [Fact]
    public void HasCertainRadius()
    {
        Circle sut = new Circle(15);
        Assert.Equal(15, sut.Radius);
    }

    [Fact]
    public void RadiusIsSetCorrectly()
    {
        Circle sut = new Circle(27);
        Assert.Equal(27, sut.Radius);
    }

    [Fact]
    public void CalculatesArea()
    {
        Circle sut = new Circle(15);
        Assert.Equal(706.858, sut.GetArea(), 3);
    }

    // Unit-tests for Triangle class
    public class TriangleCheck
    {
        [Fact]
        public void HasTwoEqualMaxSides()
        {
            Triangle sut = new Triangle(3, 6, 6);
            List<double> sides = new List<double> { sut.SideA, sut.SideB, sut.SideC };
            sut.NumberOfEqualMaxSides(sides);
            Assert.Equal(2, sut.NumberOfEqualMaxSides(sides));
        }
        [Fact]
        public void SideBEquals6()
        {
            Triangle sut = new Triangle(2, 6, 4);
            Assert.Equal(6, sut.SideB);
        }
        [Fact]
        public void HasAllSidesEqual()
        {
            Triangle sut = new Triangle(6, 6, 6);
            List<double> sides = new List<double> { sut.SideA, sut.SideB, sut.SideC };
            sut.NumberOfEqualMaxSides(sides);
            Assert.Equal(3, sut.NumberOfEqualMaxSides(sides));
        }
        [Fact]
        public void IsRightTriangle()
        {
            Triangle sut = new Triangle(3, 5, 4);
            Assert.True(sut.IsRightTriangle(sut.SideA, sut.SideB, sut.SideC));
        }

        [Fact]
        public void CalculatesArea()
        {
            Triangle sut = new Triangle(3, 5, 6);
            Assert.Equal(7.483, sut.GetArea(), 3);
        }
    }
}

