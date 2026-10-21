using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Inhertiance
{
    internal class Parent
    {
        public int A { get; set; }

        //public Parent()
        //{ 
        //}

        public Parent(int _a)
        {
            A = _a;
        }

        public void MyFunc01()
        {
            Console.WriteLine("Hi I am Parent");
        }

        public void MyFunc02()
        {
            Console.WriteLine($"Parent : A = {A}");
        }
    }

    class Child : Parent
    {
        //clr will generate empty parameterless constructor because there is no user-defined constructor exists
        //public Child() : base() { } //by default => parent has no paramterless constructor
        //public Child() : base(10) { }



        //public int A { get; set; }
        public int B { get; set; }

        ///in inheritance => child constructor must call parent constructor
        ///by default will call paramterless constructor of parent
        ///constructor channing
        public Child(int _a, int _b)  : base(_a)
        {
            //A = _a;
            B = _b;
        }

        //public void MyFunc01()
        //{
        //    Console.WriteLine("Hi I am Child");
        //}

        //public void MyFunc02()
        //{
        //    Console.WriteLine($"Child : A = {A} , B = {B}");
        //}
    }

    class Child02 : Parent
    {
        //public int A { get; set; }
        public int Z { get; set; }
        public Child02(int _a, int _z) : base(_a) 
        {
            //A = _a;
            Z = _z;
        }

        //public void MyFunc01()
        //{
        //    Console.WriteLine("Hi I am Child02");
        //}

        //public void MyFunc02()
        //{
        //    Console.WriteLine($"Child02 : A = {A} , Z = {Z}");
        //}
    }

    class Child03 : Parent
    {
        //public int A { get; set; }
        public int Y { get; set; } 
        public Child03(int _a, int _y) : base(_a) 
        {
            //A = _a;
            Y = _y;
        }

        //public void MyFunc01()
        //{
        //    Console.WriteLine("Hi I am Child03");
        //}

        //public void MyFunc02()
        //{
        //    Console.WriteLine($"Child03 : A = {A} , Y = {Y}");
        //}
    }
}
