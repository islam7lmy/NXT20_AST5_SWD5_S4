using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Sealed
{
    internal class Parent
    {
        private int salary;

        public virtual int Salary
        {
            get { return salary; }
            set { salary = value - 1000; }
        }

        public virtual void Print()
        {
            Console.WriteLine("Hello Parent");
        }

    }

    class Child : Parent
    {
        public sealed override int Salary
        {
            get => base.Salary;
            set => base.Salary = value - 500;
        }

        public sealed override void Print()
        {
            Console.WriteLine("Hello Child");
        }
    }

    sealed class GrandChiild : Child
    {
        // Not Valid with Sealed Method
        //public override int Salary
        //{
        //    get => base.Salary;
        //    set => base.Salary = value - 100;
        //}

        public new int Salary
        {
            get => base.Salary;
            set => base.Salary = value - 100;
        }

        public new void Print()
        {
            Console.WriteLine("Hello Child");
        }
    }

    //class GrandGrandChild : GrandChiild
    //{

    //}
}
