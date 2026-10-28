using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Interfaces
{
    /// interface : is a contract that define a set of 
    /// methods, properties, events, or indexers that a class or struct must implement.
    interface IMyType
    {
        /// What You Can Write Inside The Interface?
        /// methods signature
        /// properties signature
        /// events signature
        /// indexers signature
        /// Default Implementations => C# 8.0


        /// Default acces modifiers inside the interface is Public
        /// private is not allowed inside the interface

        ///property signature
        int Salary { get; set; }

        ///method signature
        void MyFun();

        void Print()
        {
            Console.WriteLine("Hello I am Default Implementation");
        }
    }

    ///cr => salary - 1000
    ///myfun => hello print
    class MyType : IMyType //implmintation
    {
        //clr will generate backing field
        //public int Salary { get; set; }

        private int _salary;

        public int Salary
        {
            get { return _salary; }
            set { _salary = value <= 2000 ? 2000 : value; }
        }

        public void MyFun()
        {
            Console.WriteLine("Hello");
        }
    }

    class MyTypev2 : IMyType //=> implementation
    {
        private int _salary;
        public int Salary
        {
            get { return _salary; }
            set { _salary = value - 1000; }
        }

        public void MyFun()
        {
            Console.WriteLine("Hello print");
        }
    }

    class MyTypev3 : IMyType //=> implementation
    {
        public int Salary { get; set; }

        public void MyFun()
        {
            Console.WriteLine("Hello I am new type");
        }
    }
}
