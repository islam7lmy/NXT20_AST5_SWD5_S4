using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Static
{
    /// Static Class
    /// is a just Container For Static Members [Attribute, Property, Constructor, Method] 
    /// You Can't Create Object From This Class (Helper Class)
    /// No Inheritance for this Class

    //static method
    internal static class Utility
    {
        public static void Swap(ref int obj1, ref int obj2)
        {
            int temp = obj1;
            obj1 = obj2;
            obj2 = temp;
        }

        public static void Hello()
        {
            Console.WriteLine("Hello");
        }


        public static double PI { get; private set; }

        //public const double PI = 3.14;
        public static double CalcCircleArea(double Radius)
        {
            //return 3.14 * Radius * Radius;
            //return Math.PI * Radius * Radius;
            return Math.PI * Radius * Radius;
        }

        /// Static Constructor [Maximum Only One Static Constructor Per Class]
        /// Can't Specifiy Access Modifiers or Parameters for Static Constructor
        /// Will be Executed Just Only One Time Per Class Lifetime Before the firts Usage of Class
        /// Usages Of Class
        /// 1. Call Static Mehtod or Static Property
        /// 2. set value for static property or filed

        static Utility()
        {
            Hello();
            PI = 3.14;

        }

    }
}
