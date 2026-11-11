using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Generics
{
    internal static class Helper
    {
        #region Ex01: Swap
        #region NonGenerics
        //public static void Swap(ref int obj1, ref int obj2)
        //{
        //    int temp = obj1;
        //    obj1 = obj2;
        //    obj2 = temp;
        //}
        //public static void Swap(ref double obj1, ref double obj2)
        //{
        //    double temp = obj1;
        //    obj1 = obj2;
        //    obj2 = temp;
        //}
        //public static void Swap(ref string obj1, ref string obj2)
        //{
        //    string temp = obj1;
        //    obj1 = obj2;
        //    obj2 = temp;
        //}

        public static void Swap(ref object obj1, ref object obj2)
        {
            object temp = obj1;
            obj1 = obj2;
            obj2 = temp;
        }
        #endregion
        #region Generics
        public static void Swap<hamada>(ref hamada obj1, ref hamada obj2)
        {
            hamada temp = obj1;
            obj1 = obj2;
            obj2 = temp;
        }
        #endregion
        #endregion

        #region Ex02: SearchArray
        public static int SearchArray<T>(T[] arr, T value)
        {
            if (arr is not null)
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    //if (arr[i] == value)
                    if (arr[i].Equals(value))
                        return i;
                }
            }

            return -1;
        }
        #endregion
    }
}
