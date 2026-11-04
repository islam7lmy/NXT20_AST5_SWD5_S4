using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Abstraction
{

    ///area 
    ///Perimeter
    interface IShape
    {
        double Perimeter();
        double Area();
    }

    ///not fully implmented
    ///can not create object of abstract class
    abstract class ShapeBase : IShape
    {
        ///not fully implmented
        public abstract double Perimeter();
        public abstract double Area();
        protected double ValidateDimensions(double dimension,string Parmname)
        {
            if (dimension <= 0)
                throw new ArgumentException($"{Parmname} must be greater than zero.");
            return dimension;
        }
    }

    internal class Square : ShapeBase
    {
        public double Side { get; }
        public Square(double side)
        {
            Side = ValidateDimensions(side,nameof(Side));
        }
        public override double Perimeter()
        {
            return 4 * Side;
        }
        public override double Area()
        {
            return Side * Side;
        }
    }

    internal class Circle : ShapeBase
    {
        public double Radius { get; }
        public Circle(double radius)
        {
            Radius = ValidateDimensions(radius,nameof(Radius));
        }
        public override double Perimeter()
        {
            return 2 * Math.PI * Radius;
        }
        public override double Area()
        {
            return Math.PI * Radius * Radius;
        }
    }
}
