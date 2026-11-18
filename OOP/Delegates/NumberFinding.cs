using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Delegates
{
    public delegate bool NumberFindingFuncDelegate(int number);
    public delegate bool GenericsNumberFindingFuncDelegate<T>(T number);

    internal static class NumberFinding
    {
        #region without Delegate
        //public static List<int> FindNumbers(List<int> numbers)
        //{
        //    List<int> filterdNumbers = new List<int>();
        //    foreach (int number in numbers)
        //    {
        //        if (number % 2 == 1)
        //            filterdNumbers.Add(number);
        //    }
        //    return filterdNumbers;
        //}

        //public static List<int> FindNumbers2(List<int> numbers)
        //{
        //    List<int> filterdNumbers = new List<int>();
        //    foreach (int number in numbers)
        //    {
        //        if (number % 2 == 0)
        //            filterdNumbers.Add(number);
        //    }
        //    return filterdNumbers;
        //}

        //public static List<int> FindNumbers7(List<int> numbers)
        //{
        //    List<int> filterdNumbers = new List<int>();
        //    foreach (int number in numbers)
        //    {
        //        if (number % 7 == 0)
        //            filterdNumbers.Add(number);
        //    }
        //    return filterdNumbers;
        //} 
        #endregion

        //public static List<int> FindNumbers(List<int> numbers, NumberFindingFuncDelegate reference)
        //{
        //    List<int> filterdNumbers = new List<int>();
        //    foreach (int number in numbers)
        //    {
        //        //if (number % 7 == 0)
        //        if (reference(number))
        //            filterdNumbers.Add(number);
        //    }
        //    return filterdNumbers;
        //}


        //public static List<T> FindNumbers<T>(List<T> numbers, GenericsNumberFindingFuncDelegate<T> reference)
        //{
        //    List<T> filterdNumbers = new List<T>();
        //    foreach (T number in numbers)
        //    {
        //        //if (number % 7 == 0)
        //        if (reference(number))
        //            filterdNumbers.Add(number);
        //    }
        //    return filterdNumbers;
        //}


        public static List<T> FindNumbers<T>(List<T> numbers, Predicate<T> reference)
        {
            List<T> filterdNumbers = new List<T>();
            foreach (T number in numbers)
            {
                //if (number % 7 == 0)
                if (reference(number))
                    filterdNumbers.Add(number);
            }
            return filterdNumbers;
        }
    }

    static class NumberConditions
    {
        public static bool IsOdd(int number)
        {
            return number % 2 == 1;
        }
        public static bool IsEven(int number)
        {
            return number % 2 == 0;
        }

        public static bool Checklength4(string str)
        {
            return str.Length > 4;
        }
    }
}
