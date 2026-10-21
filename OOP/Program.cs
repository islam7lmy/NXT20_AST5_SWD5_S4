using FirstCode;
using Commen;
using Commen01;
using OOP.Inhertiance;

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
            //Employee emp = new Employee();
            //Console.WriteLine(emp.GetSalary());

            //emp = new Employee(10, "ahmed ibrahem omar ahmed ali omer", 1000, 0);
            //Console.WriteLine(emp.GetSalary());

            //emp.SetSalary(15);
            //Console.WriteLine(emp.GetSalary());

            //emp.SetSalary(10000);
            //Console.WriteLine(emp.GetSalary());

            //emp.Salary = 15;
            //Console.WriteLine(emp.Salary);

            ////emp.Id = 10;
            //Console.WriteLine(emp.Id);
            #endregion
            #region Ex 03 : PhoneBook
            //name => number
            //addcontact
            //removecontact
            //setcontact(name,number)
            //getcontact(name)
            //loop to print all book


            //PhoneBook Book = new PhoneBook();
            ////Console.WriteLine($"book size : {Book.Size} , book elments count : {Book.Count}");
            //Book.AddContact("ali", "010000000001");
            //Book.AddContact("omr", "010000000002");
            //Book.AddContact("ahmed", "010000000003");
            //Book.AddContact("amr", "010000000004");
            //Book.AddContact("saad", "010000000005");
            ////Console.WriteLine($"book size : {Book.Size} , book elments count : {Book.Count}");

            ////for (int i = 0; i < Book.Count; i++)
            ////{
            ////    Console.WriteLine(Book[i]);
            ////}

            //Book["ali"] = "0100000000234";
            //Console.WriteLine(Book["ali"]);
            #endregion
            #endregion

            #region Class
            #region Ex:Car
            //Car c1;
            ///declare reference of type car refer to null
            ///allocate 4 bytes uninitlized in stack
            ///zero byte will be allocated in heab
            //Console.WriteLine(c1);

            //not valid because no object cerated yet
            //c1.Id = 10; 
            //c1.Model = "BMW";
            //c1.Speed = 320;

            ///c1 = new Car();
            ///new
            ///allocate required bytes in heab for created object
            ///initilize object memebers with there default value
            ///call user defined constructor if exists
            ///assign reference to the created object

            //c1 = new Car(10,"BMW",320);
            //Console.WriteLine(c1);
            //c1.Id = 10;
            //c1.Model = "BMW";
            //c1.Speed = 320;



            //Point p1;
            //Console.WriteLine(p1);
            //p1.X = 10;
            //p1.Y = 10;
            //Console.WriteLine(p1);
            //p1 = new Point();
            ///new => constructor selector 



            //Car c1;
            ////c1 = new Car(40, "BYD", 420);
            ////c1 = new Car(30, "BMW");  
            ////c1 = new Car(20);  
            //c1 = new Car();

            //Console.WriteLine($"c1 = {c1.Id} , {c1.Model} , {c1.Speed}");

            #endregion
            #region Inheritance
            //object obj = new object();
            //obj.GetHashCode();

            //int x = 3;
            //x.GetHashCode();

            //Parent p = new Parent(10);
            //p.A = 20;
            //p.MyFunc01();
            //p.MyFunc02();

            //Child c = new Child(10, 20);
            //c.A = 30;
            //c.B = 50;
            //c.MyFunc01();
            //c.MyFunc02();



            #endregion
            #endregion
        }
    }
}
