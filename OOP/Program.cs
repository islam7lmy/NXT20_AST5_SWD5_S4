using Commen;
using Commen01;
using FirstCode;
using Microsoft.VisualBasic;
using OOP.Abstraction;
using OOP.Inhertiance;
using OOP.Interfaces;
using OOP.OperatorOverloading;
using OOP.PolyMorphism_Overriding;
using OOP.Sealed;
using OOP.Static;

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
            //Interfaces.Employee emp = new Interfaces.Employee();
            //emp.Id = 10;
            //emp.Name = "Ahmed";
            //emp.Salary = 1000;
            //emp.Address = "cairo";

            //Console.WriteLine(emp);

            //Interfaces.Employee emp01 = new Interfaces.Employee();
            //emp01.Id = 20;
            //emp01.Name = "ali";
            //emp01.Salary = 1500;
            //emp01.Address = "banha";

            //Console.WriteLine(emp01);


            //Console.WriteLine($"emp : {emp.GetHashCode()}");
            //Console.WriteLine($"emp01 : {emp01.GetHashCode()}");

            /////apply deep copy on employee
            //Console.WriteLine("after deep copy");
            ////emp01 = emp.DeepCopy();
            ////emp01 = new Interfaces.Employee(emp); //copy constructor
            //emp01 = (Interfaces.Employee)emp.Clone();

            //DeepCopy(ref emp01, emp);


            //Console.WriteLine($"emp : {emp.GetHashCode()}");
            //Console.WriteLine($"emp01 : {emp01.GetHashCode()}");

            //emp01.Id = 400;
            //Console.WriteLine(emp);
            //Console.WriteLine(emp01);
            #endregion
            #region Built-In Interface IComparable
            //int[] arr = { 9, 8, 11, 7, 2, 3, 4, 5, 1 };
            ////Array.Sort(arr);

            //for (int i = 0; i < arr.Length; i++)
            //{
            //    for (int j = 0; j < arr.Length - i - 1; j++) //9 - 0 = 8
            //    {
            //        if (arr[j] > arr[j + 1])
            //            Swap(ref arr[j], ref arr[j + 1]);
            //    }
            //}
            //foreach (int item in arr)
            //{
            //    Console.Write($"{item}\t");
            //}
            //Console.WriteLine();


            //string[] strings = { "omr", "ahmed", "ali" };
            //////Array.Sort(strings);
            //Sorting(strings);
            //for (int i = 0; i < strings.Length; i++)
            //{
            //    for (int j = 0; j < strings.Length - i - 1; j++)
            //    {
            //        //if (strings[j] > strings[j + 1])
            //        if (string.Compare(strings[j], strings[j + 1]) > 0)
            //            Swap(ref strings[j], ref strings[j + 1]);
            //    }
            //}

            //foreach (string item in strings)
            //{
            //    Console.Write($"{item}\t");
            //}
            //Console.WriteLine();


            //Interfaces.Employee[] employees =
            //{
            //    new Interfaces.Employee(30,"omr",2000,"alex"),
            //    new Interfaces.Employee(40,"amr",2500,"giza"),
            //    new Interfaces.Employee(10,"ahmed",1000,"cairo"),
            //    new Interfaces.Employee(20,"ali",1500,"banha"),
            //};

            //Array.Sort(employees);

            //Sorting(employees);
            //for (int i = 0; i < employees.Length; i++)
            //{
            //    for (int j = 0; j < employees.Length - i - 1; j++)
            //    {
            //        //if (employees[j] > employees[j + 1])
            //        if (employees[j].CompareTo(employees[j + 1]) > 0)
            //            Swap(ref employees[j], ref employees[j + 1]);
            //    }
            //}

            //foreach (Interfaces.Employee emp in employees)
            //{
            //    Console.WriteLine(emp);
            //}
            #endregion
            #endregion

            #region Abstraction
            //ShapeBase shape; //= new ShapeBase();
            //shape = new Square(10);
            //Console.WriteLine(shape.Area());
            //Console.WriteLine(shape.Perimeter());
            #endregion

            #region Operator OverLoading
            ////5 + 7i => complex
            //Complex c1 = new Complex(1, 2);
            //Complex c2 = new Complex(1, 9);
            //Complex c3 = new Complex(3, 4);
            //Complex c5 = default; //refer to null

            //Complex c4 = c1 + c2 + c3 + c5;

            //Console.WriteLine(c4);

            //Console.WriteLine(c1++); //print c1 then incress => print => 1+2i then value => 2+3i
            //Console.WriteLine(++c1); //incress then print => 3+4i
            //Console.WriteLine(c1--); //print c1 then decress => print => 3+4i then value => 2+3i
            //Console.WriteLine(--c1); //decress then print => 1+2i


            ////if (c1 > c2)
            ////    Console.WriteLine("c1 is greater than c2");
            ////else
            ////    Console.WriteLine("c1 is less than c2");


            #region Equals and GetHashcode
            //Complex c1 = new Complex(1, 2);
            //Complex c2 = new Complex(1, 2);
            //Console.WriteLine(c1.GetHashCode());
            //Console.WriteLine(c2.GetHashCode());
            //if (c1 == c2)
            //    Console.WriteLine("c1 is equal to c2");
            //else
            //    Console.WriteLine("c1 is not equal to c2");

            //if (c1.Equals(c2))
            //    Console.WriteLine("c1 is equal to c2");
            //else
            //    Console.WriteLine("c1 is not equal to c2");

            //HashSet<Complex> complexSet = new HashSet<Complex>();
            //complexSet.Add(c1);
            //complexSet.Add(c2);
            //Console.WriteLine(complexSet.Count);

            ////string s1 = new string("ahmed");
            ////string s2 = new string("ahmed");
            ////Console.WriteLine(s1.GetHashCode());
            ////Console.WriteLine(s2.GetHashCode());
            ////if (s1 == s2)
            ////    Console.WriteLine("s1 is equal to s2");
            ////else
            ////    Console.WriteLine("s1 is not equal to s2");
            ////HashSet<string> stringSet = new HashSet<string>();
            ////stringSet.Add(s1);
            ////stringSet.Add(s2);
            ////Console.WriteLine(stringSet.Count);

            /////compare hashcode of two objects if equals => hashcode collision
            /////compare values of Two objects using equals method


            ////int x = 3;
            ////int y = 3;
            ////if(x == y)
            ////    Console.WriteLine("x is equal to y");
            ////else
            ////    Console.WriteLine("x is not equal to y"); 
            #endregion
            #endregion

            #region User-Defined Casting Operator
            //int x = 5;
            //double y = 10;
            //y = x; //implicit casting
            //y = 1.25;
            //x = (int)y; // explicit casting

            //x.Add(10);

            //IntExtintions.Add(x, 10);


            //OperatorOverloading.Employee emp = new OperatorOverloading.Employee();
            //emp.Id = 10;
            //emp.FirstName = "Ahmed";
            //emp.LastName = "Ali";
            //emp.BirthDate = new DateOnly(2000, 03, 15);
            //emp.Salary = 3_000;
            //emp.Address = new Address();
            //emp.Address.Details = "el gala street";
            //emp.Address.City = "Cairo";
            //emp.Address.Country = "Egypt";

            //OperatorOverloading.Employee emp = new OperatorOverloading.Employee()
            //{
            //    Id = 10,
            //    FirstName = "Ahmed",
            //    LastName = "Ali",
            //    BirthDate = new DateOnly(2000, 03, 15),
            //    Salary = 3_000,
            //    Address = new Address()
            //    {
            //        Details = "el gala street",
            //        City = "Cairo",
            //        Country = "Egypt",
            //    }
            //};

            //OperatorOverloading.Employee emp02 = new OperatorOverloading.Employee(emp);
            ////emp02.Salary = 10_000;
            ////emp02.Address.City = "banha";

            //Console.WriteLine(emp.Salary);
            //Console.WriteLine(emp.Address.City);


            //EmployeeViewModel empview = new EmployeeViewModel();
            ////{
            ////    FullName = $"{emp.FirstName} {emp.LastName}",
            ////    Age = DateTime.Now.Year - emp.BirthDate.Year,
            ////    Address = $"{emp.Address.Details}, {emp.Address.City}, {emp.Address.Country}",
            ////    NetSalary = emp.Salary - emp.Detuctions,
            ////};

            ////empview = new EmployeeViewModel(emp); //copy constructor
            ////empview = emp; //implicit casting not recomended
            ////empview = (EmployeeViewModel)emp; //explicit casting recomended
            //empview = emp.ToEmployeeViewModel(); //Extintion method
            //empview = EmployeeExtintions.ToEmployeeViewModel(emp);

            //Console.WriteLine(empview);
            #endregion

            #region static
            //Utility.PI = 1.2;
            //Console.WriteLine(Utility.PI);
            //Utility utility = new Utility();
            //Console.WriteLine(Utility.CalcCircleArea(10));
            //Console.WriteLine(Utility.PI);
            #endregion

            #region Sealed
            //Sealed.Parent c = new GrandChiild();
            //c.Salary = 5000;
            //Console.WriteLine(c.Salary);
            #endregion

            #region Generics
            #region Ex:01
            #region NonGenerics
            //int num1 = 10, num2 = 20;
            //object obj1 = num1, obj2 = num2; // boxing
            //Generics.Helper.Swap(ref obj1, ref obj2);
            ////Generics.Helper.Swap(ref num1, ref num2);
            //num1 = (int)obj1; // unboxing
            //num2 = (int)obj2; // unboxing
            //Console.WriteLine($"num1 : {num1} , num2 : {num2}");

            //double num3 = 10.25, num4 = 20.15;
            //object obj3 = num3, obj4 = num4;
            //Generics.Helper.Swap(ref obj3, ref obj4);
            ////Generics.Helper.Swap(ref num3, ref num4);
            //num3 = (double)obj3;
            //num4 = (double)obj4;
            //Console.WriteLine($"num3 : {num3} , num4 : {num4}");

            //string str1 = "Ahmed", str2 = "Mohmed";
            //Generics.Helper.Swap(ref str1, ref str2);
            //Console.WriteLine($"str1 : {str1} , str2 : {str2}");

            //decimal x = 10.3m, y = 18.66m;
            //Generics.Helper.Swap(ref x, ref y);
            #endregion
            #region Generics
            //int num1 = 10, num2 = 20;
            //Generics.Helper.Swap<int>(ref num1, ref num2);
            //Console.WriteLine($"num1 : {num1} , num2 : {num2}");

            //double num3 = 10.25, num4 = 20.15;
            //Generics.Helper.Swap<double>(ref num3, ref num4);
            //Console.WriteLine($"num3 : {num3} , num4 : {num4}");

            //string str1 = "Ahmed", str2 = "Mohmed";
            //Generics.Helper.Swap<string>(ref str1, ref str2);
            //Console.WriteLine($"str1 : {str1} , str2 : {str2}");

            //decimal x = 10.3m, y = 18.66m;
            //Generics.Helper.Swap(ref x, ref y);

            #endregion
            #endregion
            #region Ex:02
            //int[] numbers = { 5, 3, 2, 19, 4, 10, 1, 4 };
            //int postion = Array.IndexOf(numbers, 4);
            //int postion2 = Generics.Helper.SearchArray(numbers, 4);
            //Console.WriteLine(postion);
            //Console.WriteLine(postion2);

            //Generics.Point[] points =
            //{
            //    new Generics.Point(0,0),
            //    new Generics.Point(1,1),
            //    new Generics.Point(2,2),
            //    new Generics.Point(3,3),
            //    new Generics.Point(4,4),
            //    new Generics.Point(5,5)
            //};

            //int postion = Generics.Helper.SearchArray(points, new Generics.Point(4, 4));
            //int postion2 = Array.IndexOf(points, new Generics.Point(4, 4));
            //Console.WriteLine(postion);
            //Console.WriteLine(postion2);

            #endregion
            #region Ex:03 [Quiz]
            //Generics.Point[] points =
            //{
            //    new Generics.Point(0,0),
            //    new Generics.Point(1,1),
            //    new Generics.Point(2,2),
            //    new Generics.Point(3,3),
            //    new Generics.Point(4,4),
            //    new Generics.Point(5,5)
            //};
            //Generics.Point max = Generics.Helper.GetMax(points);
            //Console.WriteLine(max);

            //int[] numbers = { 5, 3, 2, 19, 4, 10, 1, 4 };
            //int Max = Generics.Helper.GetMax(numbers);
            //Console.WriteLine(Max);
            #endregion
            #endregion

            #region Delegates

            #endregion
            #region Events

            #endregion
            #region ef

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


        #region Swap
        public static void Swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }

        public static void Swap(ref string a, ref string b)
        {
            string temp = a;
            a = b;
            b = temp;
        }

        public static void Swap(ref Interfaces.Employee a, ref Interfaces.Employee b)
        {
            Interfaces.Employee temp = a;
            a = b;
            b = temp;
        }


        //public static void Swap(ref IComparable a, ref IComparable b)
        //{
        //    IComparable temp = a;
        //    a = b;
        //    b = temp;
        //}

        public static void Sorting(IComparable[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length - i - 1; j++) //9 - 0 = 8
                {
                    if (arr[j].CompareTo(arr[j + 1]) > 0)
                    //Swap(ref arr[j], ref arr[j + 1]);
                    {
                        IComparable temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }
        }

        #endregion
        #endregion
    }


}
