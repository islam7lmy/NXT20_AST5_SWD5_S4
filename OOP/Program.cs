using FirstCode;
using Commen;
using OOP.PolyMorphism_Overriding;
using Commen01;
using OOP.Inhertiance;
using OOP.Interfaces;

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
            #region Class vs Struct
            //Car c1 = new Car();
            //Car c2 = c1; // Shallow copy => copy just reference 
            //c2.Id = 99;
            //Console.WriteLine(c1.Id);// 99 because c1 and c2 refer to the same object in heab

            ///not valid
            //Car c;
            //c.Id = 10;
            //c.Speed = 320;
            //c.Model = "BMW";

            ///reference type => stored reference in stack and object in heap
            ///instiliztion => must call constructor
            ///clr will always generate empty parameterless constructor ,if no user-defined constructor exists 
            ///clr will no longer generate empty parameterless constructor, if u write user-defined constructor
            ///empty parameterless constructor => do nothing 
            ///Supports inheritance => [all access modifers]
            ///used for complex objects and behaviors

            //Point p1 = new Point();
            //Point p2 = p1;// deep copy => p2 is a copy of p1 but refer to different memory address
            //p2.X = 10;
            //p2.Y = 20;
            //p2.X = 99;
            //Console.WriteLine(p1.X); //0

            //Point p;
            //p.X = 10;
            //p.Y = 20;
            //Console.WriteLine(p1.X);
            ///value type => srtored in stack
            ///instiliztion => mustnot call constructor
            ///clr will always Generate Parameterless Constructor
            ///default constructor => initialize the attributes of struct with their default values
            ///Cannot inherit from another struct =>  [private, internal, public]
            ///often used for small and simple data => recomanded 16 bytes or less


            //PhoneBook book = new PhoneBook();
            //book.AddContact("ahmed", "0123456789");
            //book.AddContact("ali", "0123456788");
            //book.AddContact("omr", "0123456787");
            ////for (int i = 0; i < book.Count; i++)
            ////{
            ////    Console.WriteLine(book[i]);
            ////}

            //PhoneBook Book1 = book;
            //Book1["ahmed"] = "0000000000";

            ////Book1 = new PhoneBook();
            //Book1.Names = new string[10];
            //Book1.Numbers = new string[10];

            //Console.WriteLine(book["ahmed"]);
            //Console.WriteLine(Book1["ahmed"]);


            #endregion
            #endregion

            #region PolyMorphism
            #region 1. OverLoading
            //int num1 = 10, num2 = 20;
            //Sum(num1, num2);

            //double num03 = 15.5, num04 = 10.25;
            //Sum(num03, num04);

            //int x = 10;
            //x.ToString()
            #endregion
            #region 2. Overriding
            //PolyMorphism_Overriding.TypeA typeA = new PolyMorphism_Overriding.TypeA(10);
            //typeA.MyFun01();
            //typeA.MyFun02();

            //PolyMorphism_Overriding.TypeB typeB = new PolyMorphism_Overriding.TypeB(10, 20);
            //typeB.MyFun01();
            //typeB.MyFun02();
            #endregion
            #endregion

            #region Binding
            //PolyMorphism_Overriding.TypeA typeA;
            /////// allocate 4 byte for reference from type employee in stack refer to null

            //typeA = new PolyMorphism_Overriding.TypeA(10);
            ///// allocate object in heap
            #region What is binding
            ///// reference from base type => object from derived type
            //PolyMorphism_Overriding.Employee emp01;
            //emp01 = new FullTimeEmployee();

            //emp01.Id = 10;
            //emp01.Name = "Ahmed";
            //emp01.Age = 30;
            ////emp01.Salary = 10;//not valid

            //emp01.ShowRole(); // hidding => static => will run ralted to reference 
            //emp01.PrintDetials(); // overriding => dynamic => will run ralted to object 
            #endregion

            #region Not Binding
            //FullTimeEmployee emp = (FullTimeEmployee)new PolyMorphism_Overriding.Employee();

            //int x = 10;
            //object obj = x; //boxing 
            //obj = "test"; //object => string => binding

            //string yy = obj; ///not binding


            //x = (int)obj;

            /////animal = dog
            /////animal = cat
            /////dog =(dog) animal
            #endregion

            #region why Binding
            //FullTimeEmployee fullTime = new FullTimeEmployee();
            //PartTimeEmployee partTime = new PartTimeEmployee();
            //FreeLanceEmployee freeLance = new FreeLanceEmployee();
            //DayFullTimeEmployee dayFullTimeEmployee = new DayFullTimeEmployee();
            //NightFullTimeEmployee nightFullTimeEmployee = new NightFullTimeEmployee();

            //ProcessEmployee(fullTime);
            //ProcessEmployee(partTime);
            //ProcessEmployee(freeLance);
            //ProcessEmployee(dayFullTimeEmployee);
            //ProcessEmployee(nightFullTimeEmployee);
            #endregion

            #region  More Practise on Binding
            //PolyMorphism_Overriding.TypeA typeA = new PolyMorphism_Overriding.TypeC(1, 2, 3);
            //typeA.A = 11;
            ////typeA.B = 10;
            ////typeA.C = 20;

            //typeA.MyFun01(); //TypeA
            //typeA.MyFun02(); //TypeC

            //PolyMorphism_Overriding.TypeB typeB = new PolyMorphism_Overriding.TypeC(1, 2, 3);
            //typeB.A = 11;
            //typeB.B = 10;
            ////typeA.C = 20;

            //typeB.MyFun01(); //TypeB
            //typeB.MyFun02(); //TypeC


            //PolyMorphism_Overriding.TypeA typeA1 = new TypeE(1, 2, 3, 4, 5);
            //TypeB typeB1 = new TypeE(1, 2, 3, 4, 5);
            //PolyMorphism_Overriding.TypeC typeC1 = new TypeE(1, 2, 3, 4, 5);
            //TypeD typeD1 = new TypeD(1, 2, 3, 4);
            //TypeD typeD2 = new TypeE(1, 2, 3, 4, 5);
            //TypeD typeD3 = new TypeF(1, 2, 3, 4, 5);


            //typeA1.MyFun02(); //TypeC
            //typeB1.MyFun02(); //TypeC
            //typeC1.MyFun02(); //TypeC
            //typeD1.MyFun02(); //TypeD
            //typeD2.MyFun02(); //TypeE
            //typeD3.MyFun02(); //TypeD
            #endregion
            #endregion

            #region Interfaces
            #region Ex01
            //MyType myType = new MyType();
            //MyTypev2 myType = new MyTypev2();
            //IMyType myType = new IMyType(); //not valid => not implmented 

            //IMyType myType = new MyTypev3();
            ////<IMyType,MyType> ();
            //myType.Salary = 1000;
            //myType.MyFun();
            //myType.Print(); 
            #endregion
            #region Ex02
            //current => 0
            //getnext => incress current based on series type
            //reset => current = 0

            ///3 series type => bytwo , bythree , byseven 
            ///and allow me to add any series type as extended code not refactor

            ///class member method to print specifed number of elements
            ///of series in one line
            //SeriesByTwo seriesByTwo = new SeriesByTwo();
            //PrintSeries(seriesByTwo, 10);

            //SeriesByThree seriesByThree = new SeriesByThree();
            //PrintSeries(seriesByThree, 20);

            //SeriesByFive seriesByFive = new SeriesByFive();
            //PrintSeries(seriesByFive, 10);

            //SeriesBySeven seriesBySeven = new SeriesBySeven();
            //PrintSeries(seriesBySeven, 5);

            //SeriesByThree seriesByThree = new SeriesByThree();
            //seriesByThree.Current = 20; //not valid 
            //seriesByThree.Current = 20; //not valid
            //seriesByThree.Current = 20; //not valid

            #endregion
            #region Implment Interface Implicitly Vs Implment Interface Explicitly
            //Interfaces.IMoveable car = new Interfaces.Car();
            //car.Speed = 100;
            //car.Backward();
            //car.Forward();
            //car.Left();
            //car.Right();

            //AirPlan airPlan = new AirPlan();
            //airPlan.Speed = 300;
            ////airPlan.Forward(); //not valid
            //Console.WriteLine("------------AirPlan is move now----------------");
            //IMoveable moveableairPlan = airPlan;
            //moveableairPlan.Speed = 100;
            //moveableairPlan.Forward();
            //moveableairPlan.Backward();
            //moveableairPlan.Left();
            //moveableairPlan.Right();
            //Console.WriteLine("------------AirPlan is fly now----------------");
            //IFlyable flyableairPlan = airPlan;
            //flyableairPlan.Speed = 320;
            //flyableairPlan.Forward();
            //flyableairPlan.Left();
            //flyableairPlan.Right();

            #endregion
            #region Shallow copy vs Deep Copy
            //int x = 10;
            //int y = 20;
            //y = x;
            //y = 30;
            //Console.WriteLine(x);
            //Console.WriteLine(y);

            //int[] arr01 = { 1, 2, 3 };
            //int[] arr02 = { 4, 5, 6 };
            //Console.WriteLine($"arr01 = {arr01.GetHashCode()}");
            //Console.WriteLine($"arr02 = {arr02.GetHashCode()}");

            #region Shallow copy
            //arr02 = arr01;

            //Console.WriteLine("after shallow copy");
            //Console.WriteLine($"arr01 = {arr01.GetHashCode()}");
            //Console.WriteLine($"arr02 = {arr02.GetHashCode()}");

            //arr02[0] = 99;
            //Console.WriteLine(arr01[0]);
            #endregion

            #region Deep copy
            ////int[] test = (int[]) new object();
            //arr02 = (int[]) arr01.Clone();

            //Console.WriteLine("after Deep copy");
            //Console.WriteLine($"arr01 = {arr01.GetHashCode()}");
            //Console.WriteLine($"arr02 = {arr02.GetHashCode()}");

            //arr02[0] = 99;
            //Console.WriteLine(arr01[0]);
            #endregion

            #endregion

            #region Built-In Interface ICloneable
            Interfaces.Employee emp = new Interfaces.Employee();
            emp.Id = 10;
            emp.Name = "Ahmed";
            emp.Salary = 1000;
            emp.Address = "cairo";

            Console.WriteLine(emp);

            Interfaces.Employee emp01 = new Interfaces.Employee();
            emp01.Id = 20;
            emp01.Name = "ali";
            emp01.Salary = 1500;
            emp01.Address = "banha";

            Console.WriteLine(emp01);


            Console.WriteLine($"emp : {emp.GetHashCode()}");
            Console.WriteLine($"emp01 : {emp01.GetHashCode()}");

            ///apply deep copy on employee
            Console.WriteLine("after deep copy");
            //emp01 = emp.DeepCopy();
            //emp01 = new Interfaces.Employee(emp); //copy constructor
            emp01 = (Interfaces.Employee)emp.Clone();

            DeepCopy(ref emp01, emp);


            Console.WriteLine($"emp : {emp.GetHashCode()}");
            Console.WriteLine($"emp01 : {emp01.GetHashCode()}");

            emp01.Id = 400;
            Console.WriteLine(emp);
            Console.WriteLine(emp01);
            #endregion
            #endregion
        }

        #region PolyMorphism OverLoading
        /// 1. datatype of parameters
        /// 2. Count number of parameters
        /// 3. reOrder parameters if not same datatype
        //public static int Sum(int a, int b)
        //{
        //    return a + b;
        //}
        ////public static int Sum(int b, int a)
        ////{
        ////    return a + b;
        ////}
        //public static int Sum(int a, int b, int z)
        //{
        //    return a + b + z;
        //}
        //public static double Sum(double a, double b)
        //{
        //    return a + b;
        //}
        //public static decimal Sum(decimal a, double b)
        //{
        //    return (a + (decimal)b);
        //}
        //public static decimal Sum(double b, decimal a)
        //{
        //    return (a + (decimal)b);
        //}

        //public static void CalcBill(params menuitem[] order)
        //{

        //}

        //public static void CalcBill(decimal serviceRate,params menuitem[] order)
        //{

        //}

        //public static void CalcBill(decimal TaxRate,decimal serviceRate, params menuitem[] order)
        //{

        //}

        //public static void CalcBill(decimal Discount,decimal TaxRate, decimal serviceRate, params menuitem[] order)
        //{

        //}

        //enum menuitem { }
        #endregion
        #region Binding
        public static void ProcessEmployee(PolyMorphism_Overriding.Employee emp)
        {
            if (emp is not null)
            {
                emp.ShowRole();
                emp.PrintDetials();
            }
        }

        //public static void ProcessEmployee(FullTimeEmployee emp)
        //{
        //    if (emp is not null)
        //    {
        //        emp.ShowRole();
        //        emp.PrintDetials();
        //    }
        //}
        //public static void ProcessEmployee(PartTimeEmployee emp)
        //{
        //    if (emp is not null)
        //    {
        //        emp.ShowRole();
        //        emp.PrintDetials();
        //    }
        //}
        //public static void ProcessEmployee(FreeLanceEmployee emp)
        //{
        //    if (emp is not null)
        //    {
        //        emp.ShowRole();
        //        emp.PrintDetials();
        //    }
        //}
        #endregion
        #region InterFaces
        public static void PrintSeries(ISeries series, int number)
        {
            if (series is not null)
            {
                for (int i = 0; i < number; i++)
                {
                    Console.Write($"{series.Current} \t");
                    series.GetNext();
                }
                Console.WriteLine();
                series.Reset();
            }
        }


        ///generics
        public static void DeepCopy<T>(ref T copyin, T copyfrom) where T : ICloneable
        {
            copyin = (T)copyfrom.Clone();
        }
        #endregion
    }


}
