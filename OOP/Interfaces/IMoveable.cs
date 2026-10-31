using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Interfaces
{
    internal interface IMoveable
    {
        int Speed { get; set; }
        void Forward();
        void Backward();
        void Left();
        void Right();
    }

    internal interface IFlyable
    {
        int Speed { get; set; }
        void Forward();
        void Left();
        void Right();
    }

    class Car : IMoveable
    {
        public int Speed { get; set; }

        public void Backward()
        {
            Console.WriteLine("Car is Move BackWard");
        }

        public void Forward()
        {
            Console.WriteLine("Car is Move Forward");
        }

        public void Left()
        {
            Console.WriteLine("Car is Move Left");
        }

        public void Right()
        {
            Console.WriteLine("Car is Move Right");
        }
    }

    class AirPlan : IMoveable, IFlyable
    {
        /// implicit implment
        public int Speed { get; set; }

        /// explicit implment
        void IMoveable.Forward()
        {
            Console.WriteLine("AirPlay is move forward");
        }
        /// explicit implment
        void IFlyable.Forward()
        {
            Console.WriteLine("AirPlay is fly forward");
        }

        void IMoveable.Backward()
        {
            Console.WriteLine("AirPlay is move Backward");
        }

        void IMoveable.Left()
        {
            Console.WriteLine("AirPlay is move Left");
        }
        void IFlyable.Left()
        {
            Console.WriteLine("AirPlay is fly Left");
        }

        void IMoveable.Right()
        {
            Console.WriteLine("AirPlay is move Right");
        }
        void IFlyable.Right()
        {
            Console.WriteLine("AirPlay is fly Right");
        }
    }
}
