using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.PolyMorphism_Overriding
{
    class TypeA
    {
        public int A { get; set; }
        public TypeA(int _a)
        {
            A = _a;
        }

        public virtual void MyFun01()
        {
            Console.WriteLine("I am TypeA");
        }

        public virtual void MyFun02()
        {
            Console.WriteLine($"TypeA : A = {A}");
        }
    }

    class TypeB : TypeA
    {
        public int B { get; set; }
        public TypeB(int _a , int _b) : base(_a)
        {
            B = _b;
        }

        ///static binded method
        ///apply overriding => new keyword [hidding]
        ///compilition time
        public new void MyFun01()
        {
            Console.WriteLine("I am TypeB");
        }

        ///dynamic binded method
        ///apply overriding => override keyword
        /// to apply override => method of parent must be [not private , virtual]
        /// Runtime
        public override void MyFun02()
        {
            Console.WriteLine($"TypeB : A = {A} , B = {B}");
        }
    }
}
