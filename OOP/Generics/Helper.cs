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

        #region EX03: GetMax
        public static T GetMax<T>(T[] arr) where T : IComparable<T>
        {
            T max = arr[0];
            foreach (T item in arr)
            {
                if (item.CompareTo(max) > 0)
                    max = item;
            }
            return max;
        }
        #endregion
    }

    #region Constraints
    //T must be a reference type (class)
    public class Repository<T> where T : class
    {
        public T? Data { get; set; }
    }
    //T must be not null
    public class Repository02<T> where T : notnull
    {
        public T? Data { get; set; }
    }

    //T must be a value type (struct)
    public class Calculater<T> where T : struct
    {
        public T Value { get; set; }
    }

    //T must have a parameterless constructor
    public class Factory<T> where T : new()
    {
        public T CreateInstance()
        {
            return new T();
        }
    }

    #region BaseClass
    class Employee
    {
        public string Name { get; set; }
    }

    class Manager : Employee
    {

    }

    class Developer : Employee
    {

    }
    //T must be Employee or derived from Employee
    class EmployeeService<T> where T : Employee
    {
        public void PrintEmployeeName(T emp)
        {
            Console.WriteLine($"Employee Name: {emp.Name}");
        }
    }

    #endregion

    class Animal { }
    class Dog : Animal { }

    class AnimalContainer<T, U> where T : U
    {
        public AnimalContainer(T dog)
        {
            U animal = dog;// This is valid because T is constrained to be a subclass of U
        }
    }

    #endregion

    #region Quiz
    interface IPrintable
    {
        void Print();
    }

    class DataProcessor<T> where T : IPrintable, new()
    {
        public void Process(T item)
        {
            item = new T();
            item.Print();
        }
    }

    public class Student : IPrintable
    {
        public string Name { get; set; }
        public Student()
        {
            Name = "N/A";
        }
        public void Print()
        {
            Console.WriteLine($"Student: {Name}");
        }
    }
    #endregion
}
