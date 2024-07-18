using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDPrincipal
{
    internal interface IShape
    {
        double CalculateArea(); 
    }
    class Rectangle : IShape
    {
        public double Height { get; set; }
        public double Width { get; set; }

        public double CalculateArea()
        {
            return Height * Width;
        }
    }
    class Circle : IShape
    {
        public double Radious;
        public double CalculateArea()
        {
            return Math.PI * Radious * Radious;
        }
    }
    public class Triangle : IShape
    {
        public double Base { get; set; }
        public double Height { get; set; }

        public double CalculateArea()
        {
            return 0.5 * Base * Height;
        }
    }

    class AreaCalculator
    {
        public double CalculatArea(IShape shape)
        {
            return shape.CalculateArea();
        }
    }
}
