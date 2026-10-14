using FirstCode;
using Commen;
using Commen01;

namespace OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Access Modifiers
            //private
            //private protected  => inhertance
            //protected          => inhertance
            //internal
            //protected internal => inhertance
            //public

            //try
            //{
            //    Helper.DoSomeCode();
            //}
            //catch (Exception ex)
            //{
            //    //log 
            //    Console.WriteLine(ex.Message);
            //    //throw;
            //}

            //rank r = rank.first;

            //TypeA a = new TypeA();
            ////a.x = 10; //private only in class members
            ////a.y = 10; //assimbly
            //a.z = 10; //all

            //TypeC c = new TypeC();
            #endregion

            #region Struct
            #region Ex : Point
            //Point p1;
            /// allocate 8 bytes uninitialized in the stack memory [4 byte x , 4 byte y]
            //Console.WriteLine(p1);

            //p1.X = 10;
            //p1.Y = 10;
            //Console.WriteLine(p1);

            //p1 = new Point();
            /// new key word just for constructor selection and not for memory allocation in stack memory
            ///that will initialize the struct fields with default values

            //p1 = new Point(10, 10);
            //Console.WriteLine(p1.Y); 
            #endregion
            #region Ex : Employee
            Employee emp = new Employee();
            Console.WriteLine(emp.GetSalary());

            emp = new Employee(10, "ahmed ibrahem omar ahmed ali omer", 1000, 0);
            Console.WriteLine(emp.GetSalary());

            emp.SetSalary(15);
            Console.WriteLine(emp.GetSalary());

            emp.SetSalary(10000);
            Console.WriteLine(emp.GetSalary());
            #endregion
            #endregion
        }
    }
}
