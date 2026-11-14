using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Generics
{
    internal class Point : IComparable<Point>
    {
        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }
        public int X { get; set; }
        public int Y { get; set; }

        public int CompareTo(Point? other)
        {
            if (other is null)
                return 1;
            if (X == other.X && Y == other.Y)
                return 0;
            return X.CompareTo(other.X);
        }

        //public int CompareTo(object? obj)
        //{

        //}

        public override bool Equals(object? obj)
        {
            return obj is Point point &&
                   X == point.X &&
                   Y == point.Y;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(X, Y);
        }

        public override string ToString()
        {
            return $"({X} , {Y})";
        }

        public static bool operator ==(Point? left, Point? right)
        {
            return EqualityComparer<Point>.Default.Equals(left, right);
        }

        public static bool operator !=(Point? left, Point? right)
        {
            return !(left == right);
        }
    }
}
