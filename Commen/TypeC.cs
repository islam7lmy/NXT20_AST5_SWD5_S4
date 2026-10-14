using Commen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commen01
{
    public class TypeC
    {
        void test()
        {
            rank r = rank.first;
            TypeA a = new TypeA();
            //a.x = 10; //private only in class members
            a.y = 10; //assimbly
            a.z = 10; //all
        }
    }
}
