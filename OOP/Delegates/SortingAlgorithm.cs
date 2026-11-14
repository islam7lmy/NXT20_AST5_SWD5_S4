using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Delegates
{
    public delegate bool SortingTypesFuncDelegate(int a, int b);
    public delegate bool GenricsSortingTypesFuncDelegate<T>(T a, T b);
    internal static class SortingAlgorithm
    {
        #region Without Delegates
        public static void BubbleSortAsc(int[] arr)
        {
            if (arr is not null)
                for (int i = 0; i < arr.Length - 1; i++)
                {
                    for (int j = 0; j < arr.Length - 1 - i; j++)
                    {
                        if (arr[j] > arr[j + 1])
                            Swap(ref arr[j], ref arr[j + 1]);

                    }
                }
        }

        public static void BubbleSortDesc(int[] arr)
        {
            if (arr is not null)
                for (int i = 0; i < arr.Length - 1; i++)
                {
                    for (int j = 0; j < arr.Length - 1 - i; j++)
                    {
                        if (arr[j] < arr[j + 1])
                            Swap(ref arr[j], ref arr[j + 1]);

                    }
                }
        }

        public static void Swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }
        #endregion

        #region with Delegates
        public static void BubbleSort(int[] arr, SortingTypesFuncDelegate reference)
        {
            if (arr is not null)
                for (int i = 0; i < arr.Length - 1; i++)
                {
                    for (int j = 0; j < arr.Length - 1 - i; j++)
                    {
                        //if (arr[j] > arr[j + 1])
                        //if(function return bool and take two int parameters)
                        if (reference(arr[j], arr[j + 1]))
                            Swap(ref arr[j], ref arr[j + 1]);

                    }
                }
        }


        #endregion

        #region Generics
        public static void BubbleSort<T>(T[] arr, GenricsSortingTypesFuncDelegate<T> reference)
        {
            if (arr is not null)
                for (int i = 0; i < arr.Length - 1; i++)
                {
                    for (int j = 0; j < arr.Length - 1 - i; j++)
                    {
                        //if (arr[j] > arr[j + 1])
                        //if(function return bool and take two int parameters)
                        if (reference(arr[j], arr[j + 1]))
                            Swap(ref arr[j], ref arr[j + 1]);

                    }
                }
        }
        public static void Swap<T>(ref T a, ref T b)
        {
            T temp = a;
            a = b;
            b = temp;
        }
        #endregion
    }

    static class SortingType
    {
        public static bool SortAsc(int x, int y)
        {
            return x > y;
        }
        public static bool SortDesc(int x, int y)
        {
            return x < y;
        }

        public static bool SortAsc<T>(T x, T y) where T : IComparable<T>
        {
            return x.CompareTo(y) > 0;
        }
        public static bool SortDesc<T>(T x, T y) where T : IComparable<T>
        {
            return x.CompareTo(y) < 0;
        }
    }
}
