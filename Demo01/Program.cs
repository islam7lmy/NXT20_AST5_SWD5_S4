using System.Text;

namespace Demo01
{
    internal class Program
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            #region Comment
            // line comment

            /*
             * block comment
             * block comment
             */
            #endregion

            #region Value Type
            //int X;
            /////allocate 4 uninitialized bytes in stack
            /////int : C# Keyword

            ////Console.WriteLine(X);// invalid

            //X = 5;

            ////Console.WriteLine(X);

            //Int32 Y;
            /////allocate 4 uninitialized bytes in stack
            /////Int32 : CLS Keyword

            //Y = X;

            //X = X + 1;

            //Console.WriteLine($"X:{X}"); // 6
            //Console.WriteLine($"Y:{Y}"); // 5
            #endregion

            #region Reference Type
            //Point P1;
            ///// allocate 4 bytes in stack for reference variable P1 of type Point
            ///// referring to nothing
            ///// zero bytes allocated in heap for Point object

            ////Console.WriteLine(P1.X); //invalid, P1 is uninitialized

            //P1 = new Point();
            ///// new
            ///// 1. allocate required bytes in heap for Point object (4 bytes for X, 4 bytes for Y)
            ///// 2. initialize the allocated bytes in heap for point object  with default values depend on it's datatype [x = 0 , y = 0]
            ///// 3. call user defined constructor of Point class if exists
            ///// 4. assign the address of the allocated bytes in heap to reference P1 in stack

            //Point P2 = new Point();

            //Console.WriteLine($"P1 hashcode : {P1.GetHashCode()}");
            //Console.WriteLine($"P2 hashcode : {P2.GetHashCode()}");

            //P2 = P1;
            ///// assign the address of the allocated bytes in heap for reference P1 to reference P2 in stack
            //Console.WriteLine("after assign");
            //Console.WriteLine($"P1 hashcode : {P1.GetHashCode()}");
            //Console.WriteLine($"P2 hashcode : {P2.GetHashCode()}");

            //P1.X = 5;
            //P2.Y = 10;

            //Console.WriteLine($"P1({P1.X} , {P1.Y})");
            //Console.WriteLine($"P2({P2.X} , {P2.Y})");
            #endregion

            #region Object
            //object o1 = new object();
            //Point o2 = new Point();

            //o2.ToString();
            //o2.Equals(o1);
            //o2.GetHashCode();
            //o2.GetType();

            //int X = 5;

            //X.ToString();
            //X.Equals(o1);
            //X.GetHashCode();
            //X.GetType();

            //o1 = o2;
            //o1 = X;
            //o1 = true;
            #endregion

            #region Fractions and discards
            //int x = 1_000_000_000; // _ discard to improve readabilty

            //double d1 = 15.3;
            //float f1 = 15.3f;
            //decimal m1 = 15.3m;
            #endregion

            #region Value Type Casting
            ///1. Implicit Casting (safe casting)
            //int x = 5;
            //long y = x; // implicit casting from int to long

            ////x = y; // implicit casting from long to int (may cause data loss if y is  too large)
            //// compile time error : cannot implicitly convert long to int

            /////2. Explicit Casting (unsafe casting)
            //y = 1_000_000_000_000;
            ////x = (int) y; // xexplicit casting from long to int (may cause data loss if y is  too large)
            //long b = 1_000_000;
            //checked
            //{
            //    //int z = (int)y;
            //    int c = (int)b;
            //    unchecked
            //    {
            //        //Console.WriteLine($"Z : {z}");
            //        Console.WriteLine($"B : {b}");
            //        Console.WriteLine($"C : {c}");
            //    }
            //}
            //Console.WriteLine($"Y : {y}");
            //Console.WriteLine($"X : {x}");

            ///3. Parsing (string to value type) -->  unsafe casting
            //Console.WriteLine("please enter your name :");
            //string name = Console.ReadLine();
            //Console.WriteLine("please enter your age :");
            //int age = int.Parse(Console.ReadLine());
            //Console.WriteLine($"hello {name}, your age is {age}");
            //Console.WriteLine("hello");

            ///4. tryparse (string to value type) -->  safe casting
            //Console.WriteLine("please enter your name :");
            //string name = Console.ReadLine();
            //Console.WriteLine("please enter your age :");
            ////int age = int.Parse(Console.ReadLine());
            //if (int.TryParse(Console.ReadLine(), out int age))
            //{
            //    Console.WriteLine($"hello {name}, your age is {age}");
            //}
            //else
            //{
            //    Console.WriteLine("Invalid age input, please enter a valid integer.");
            //}

            ///5. Convert (any datatype to any datatype) --> unsafe casting
            //Console.WriteLine("please enter your name :");
            //string name = Console.ReadLine();
            //Console.WriteLine("please enter your age :");
            //int age = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine($"hello {name}, your age is {age}");
            //Console.WriteLine("hello");
            #endregion

            #region Operators
            #region Unary operator
            //int x = 10;
            ////x++; // same
            ////++x; // same
            ////x--;
            ////--x;
            /////1. prefix increment operator : increment the value of x by 1 and  returns the incremented value
            //Console.WriteLine(++x); // increment x to 11 then print 11
            /////2. postfix increment operator : return the current value of x and  then increments the value of x by 1
            //Console.WriteLine(x++); // print 11 then increment x to 12
            //Console.WriteLine(x); // print 12
            ///// 3. prefix decrement operator (--X) : decrements the value of X by 1 and returns the decremented value
            //Console.WriteLine(--x); // decrement x to 11 then print 11
            ///// 4. postfix decrement operator (X--) : returns the current value of X and then decrements the value of X by 1
            //Console.WriteLine(x--); // print 11 then decrement x to 10
            //Console.WriteLine(x); // print 10
            #endregion

            #region Binary operator
            //int Sum, Mul, Sub, Div, Mod, num1 = 10, num2 = 3;
            //Sum = num1 + num2; //addition
            //Sub = num1 - num2; //subtraction
            //Mul = num1 * num2; //multiplication
            //Div = num1 / num2; //division
            //Mod = num1 % num2; //modulus

            //int x = 10 / 3; //integer division , result is 3
            //Console.WriteLine(x);
            //double y = 10 / 3;//integer division , result is 3
            //Console.WriteLine(y);
            //double z = 10.0 / 3; //fraction divison
            //Console.WriteLine(z);

            //double Div2 = (double)num1 / num2;
            //Console.WriteLine(Div2);
            #endregion

            #region Assignment operator
            //int X;
            //X = 5;  // assignment operator
            //X += 5; // addition assignment operator, equivalent to X = X + 5;
            //X -= 3; // subtraction assignment operator, equivalent to X = X - 3
            //X *= 2; // multiplication assignment operator, equivalent to X = X * 2
            //X /= 4; // division assignment operator, equivalent to X = X / 4
            //X %= 3; // modulus assignment operator, equivalent to X = X % 3
            #endregion

            #region Realtional Operator [Comparision]
            //int X = 10, Y = 20;
            //Console.WriteLine(X == Y); //equality operator // false
            //Console.WriteLine(X != Y); //inequality operator // true
            //Console.WriteLine(X > Y); //greater than operator // false
            //Console.WriteLine(X < Y); //less than operator // true
            //Console.WriteLine(X >= Y); //greater than or equal operator // false
            //Console.WriteLine(X <= Y); //less than or equal operator // true
            #endregion

            #region Logical Operators
            //Console.WriteLine(!false); // logical NOT operator, negates the boolean value, Output: True

            ///// logical AND operator (&&) and logical OR operator (||) are short-circuit operators, meaning they only evaluate the second operand if necessary.
            //Console.WriteLine(false && true); // logical AND operator, returns true if both operands are true, Output: False
            //Console.WriteLine(true || false); // logical OR operator, returns true if at least one operand is true, Output: True


            //Console.WriteLine((4 > 5) && (7 < 9 || 5 == 5)); //false
            //Console.WriteLine(4 > 5 && 7 < 9 || 5 == 5); //true
            //Console.WriteLine((4 < 5) && (!(7 < 9) || 5 == 5)); //true
            #endregion

            #region Bitwise operator
            //Console.WriteLine(false & true); // bitwise AND operator, returns true if both operands are true, Output: False
            //Console.WriteLine(true | false); // bitwise OR operator, returns true if at least one operand is true, Output: True
            //Console.WriteLine(true ^ false); // bitwise XOR operator, returns true if operands are different, Output: True  
            #endregion

            #region Ternary operator
            //int X = 4, Y = 7, Z = 10;

            //if (X > Y)
            //    Console.WriteLine("X is greater than Y");
            //else
            //    Console.WriteLine("Y is greater than X");

            //Console.WriteLine(X > Y ? "X is greater than Y" : "Y is greater than X");

            //if (X > Y)
            //{
            //    if (X > Z)
            //    {
            //        Console.WriteLine("X is the greatest");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Z is the greatest");
            //    }
            //}
            //else
            //{
            //    if (Y > Z)
            //    {
            //        Console.WriteLine("Y is the greatest");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Z is the greatest");
            //    }
            //}

            /////// not recommended to use nested ternary operator for better readability
            //Console.WriteLine(X > Y ? (X > Z ? "X is the greatest" : "Z is the greatest") : (Y > Z ? "Y is the greatest" : "Z is the greatest"));

            #endregion

            #region Operator Priorty
            ///1. unary operator 
            ///2. round brackets ()
            ///3. multiplicative operator ( * , / , % )
            ///4. additive operator ( + , - )

            //int a = 20, b = 10, c = 15, d = 5;
            //int result = (a + b) * c / d; // 20 + 10 = 30 * 15 = 450 / 5 = 90
            //int result2 = ((--a + b) * c) / d; // 19 + 10 = 29 * 15 = 435 / 5 = 87
            //int result3 = --a + b * c / d; // 19 + 10 * 15 / 5 = 19 + 150 / 5 = 19 + 30 = 49
            //int result4 = ++a + a++ - --a - a--; // 21 + 21 - 21 - 21 = 0
            // ++a => a = 21 , value = 21
            // a++ => value = 21 , a = 22
            // --a => a = 21 , value = 21
            // a-- => value = 21 , a = 20
            #endregion
            #endregion

            #region string vs stringbuilder
            //string x = "hello"; //syntactic sugar for string x = new string("hello");
            //Console.WriteLine(x.GetHashCode());
            //x = "world"; //x = new string("world"); // x now refers to a new string object, the old string "Hello" is eligible for garbage collection
            //Console.WriteLine(x.GetHashCode());
            ////string => imutable 
            //x += "!!!"; //x = new string("world!!!"); // x now refers to a new string object, the old string "world" is eligible for garbage collection
            //Console.WriteLine(x.GetHashCode());
            ///////////////////////////////////////////////////////////////////////////
            //StringBuilder y = new StringBuilder("hello");
            //Console.WriteLine(y.GetHashCode());
            //y.Append(" world"); // modifies the existing StringBuilder object, no new object is created
            //Console.WriteLine(y.GetHashCode());
            //y.Clear(); // clears the content of the StringBuilder object, no new object is created
            //y.AppendLine("Hello world");// modifies the existing StringBuilder object, no new object is created
            //y.Insert(0, "welcome to ");// modifies the existing StringBuilder object, no new object is created
            //y.Remove(0, 11);// modifies the existing StringBuilder object, no new object is created
            //y.Replace("world", "C#"); // modifies the existing StringBuilder object, no new object is created
            //Console.WriteLine(y);
            #endregion

            #region string Formating
            // Equition : 4 +  2 = 6
            //int X = 4, Y = 2;
            //string result = "Equition : " + X + " + " + Y + " = " + (X + Y); // string concatenation

            //string result1 = "Equition : ";
            //result1 += X;
            //result1 += " + ";
            //result1 += Y;
            //result1 += " = ";
            //result1 += (X + Y);

            //StringBuilder result2 = new StringBuilder("Equition : ");
            //result2.Append(X);
            //result2.Append(" + ");
            //result2.Append(Y);
            //result2.Append(" = ");
            //result2.Append((X + Y));

            //string result3 = string.Format("Equition : {0} + {1} = {2}", X, Y, (X + Y)); // string formatting using placeholders

            //string result4 = $"Equition : {X} + {Y} = {(X + Y)}"; // string interpolation using $ and {} for expressions

            //Console.WriteLine(result);
            //Console.WriteLine(result1);
            //Console.WriteLine(result2);
            //Console.WriteLine(result3);
            //Console.WriteLine(result4);
            #endregion

            #region Conditional statment
            //if (condition) //true or false
            //{
            //    // statements to execute if condition is true
            //}
            //else if (codition2)
            //{
            //    // statements to execute if condition2 is true
            //}
            //else
            //{
            //    // statements to execute if all condition is false
            //}
            ////////////////////////////////

            //if(condition)
            //{

            //}

            //if(condition2)
            //{

            //}
            //else
            //{

            //}

            //varible = value3;
            ////jump table
            //switch(varible)
            //{
            //    case value1:
            //        //excute code
            //        break;
            //    case value2:
            //        //excute code
            //        break;
            //    case value3:
            //        //excute code
            //        break;
            //    default:
            //        //excut if no case match
            //        break;
            //}

            #region Ex01 : write a program to take number in first quarter in year and print the month name
            ///write a program to take number in first quarter in year and print the month name 
            /// {1 , 2 , 3} => {january , February , March} 

            #region IF Statment
            #region not clean
            //Console.WriteLine("insert number of month in first qurter of year :");
            //int month = int.Parse(Console.ReadLine());
            //if (int.TryParse(Console.ReadLine(), out int month))
            //{
            //    Console.WriteLine(
            //        month == 1 ? "january" :
            //        month == 2 ? "February" :
            //        month == 3 ? "March" :
            //        "Invalid month number"
            //        );

            //    if (month == 1)
            //        Console.WriteLine("january");
            //    else if (month == 2)
            //        Console.WriteLine("February");
            //    else if (month == 3)
            //        Console.WriteLine("March");
            //    else
            //        Console.WriteLine("Invalid month number");
            //}
            //else
            //{
            //    Console.WriteLine("Invalid Input, please enter a valid integer.");
            //} 
            #endregion

            //Console.WriteLine("insert number of month in first qurter of year :");
            //if (!int.TryParse(Console.ReadLine(), out int month))
            //{
            //    Console.WriteLine("Invalid Input, please enter a valid integer.");
            //    return;
            //}

            //if (month == 1)
            //    Console.WriteLine("january");
            //else if (month == 2)
            //    Console.WriteLine("February");
            //else if (month == 3)
            //    Console.WriteLine("March");
            //else
            //    Console.WriteLine("Invalid month number");

            #endregion

            #region switch
            //Console.WriteLine("insert number of month in first qurter of year :");
            //if (!int.TryParse(Console.ReadLine(), out int month))
            //{
            //    Console.WriteLine("Invalid Input, please enter a valid integer.");
            //    return;
            //}

            //switch (month)
            //{
            //    case 1:
            //        Console.WriteLine("jan");
            //        break;
            //    case 2:
            //        Console.WriteLine("feb");
            //        break;
            //    case 3:
            //        Console.WriteLine("mar");
            //        break;
            //    default:
            //        Console.WriteLine("Invalid month number");
            //        break;
            //}

            #endregion
            #endregion

            #region Ex02
            //int salary = 3000;
            //switch(salary)
            //{
            //    case 3000:
            //        Console.WriteLine("option3");
            //        //Console.WriteLine("option2");
            //        //Console.WriteLine("option1");
            //        //break;
            //        goto case 2000;
            //    case 2000:
            //        Console.WriteLine("option2");
            //        //Console.WriteLine("option1");
            //        //break;
            //        goto case 1000;
            //    case 1000:
            //        Console.WriteLine("option1");
            //        //break;
            //        goto case 3000;
            //    default:
            //        Console.WriteLine("no option");
            //        break;
            //}
            #endregion

            #region Calculater
            //take number then opertation then number and show result
            //calculater do (+ - * / %)
            //write program to do that and make it protictive

            //double result = 0;
            //Console.WriteLine("enter first number");
            //if(!int.TryParse(Console.ReadLine(),out int num01))
            //{
            //    Console.WriteLine("invalid input");
            //    return;
            //}

            //Console.WriteLine("enter operation (+ - * / %)");
            //if (
            //    !(char.TryParse(Console.ReadLine(), out char op)
            //    &&
            //    (op == '+' || op == '-' || op == '*' || op == '/' || op == '%')
            //    ))
            //{
            //    Console.WriteLine("invalid input");
            //    return;
            //}

            //Console.WriteLine("enter last number");
            //if (
            //    !int.TryParse(Console.ReadLine(), out int num02)
            //    ||
            //    ((op == '/' || op == '%') && num02 == 0)
            //    )
            //{
            //    Console.WriteLine("invalid input");
            //    return;
            //}

            //switch(op)
            //{
            //    case '+': result = num01 + num02; break;
            //    case '-': result = num01 - num02; break;
            //    case '*': result = num01 * num02; break;
            //    case '/': result = (double)num01 / num02; break;
            //    case '%': result = num01 % num02; break;
            //    //default: result = 0; break;

            //}

            //Console.WriteLine($"{num01} {op} {num02} = {result}");
            #endregion
            #endregion

            #region Loops Statment
            // 10 steps to print 1 to 10
            //Console.WriteLine("1");
            //Console.WriteLine("2");
            //Console.WriteLine("3");
            //Console.WriteLine("4");
            //Console.WriteLine("5");
            //Console.WriteLine("6");
            //Console.WriteLine("7");
            //Console.WriteLine("8");
            //Console.WriteLine("9");
            //Console.WriteLine("10");


            #region for
            // start => i = 1
            // condition => (i <= 10) => true
            // excute => Console.WriteLine(i);
            // increment => i++
            // condition => (i <= 10) => true
            // excute => Console.WriteLine(i);
            // increment => i++
            // condition => (i <= 10) => false


            //for (int i = 1; i <= 10; i++) //++i
            //{
            //    Console.WriteLine(i);
            //}


            //int x = 10;
            //++x;
            //Console.WriteLine(x); // 11
            //x++;
            //Console.WriteLine(x);

            //Console.WriteLine(++x); //11
            //Console.WriteLine(x++); //10


            //int i = 1; //start
            //for(; ;i++)
            //{
            //    if (!(i <= 10))
            //        break; //condition

            //    if (i % 2 == 0)
            //    {
            //        //i++;
            //        continue; //skip current loop
            //    }

            //    Console.WriteLine(i); //excute

            //    //i++; //increment
            //}
            #endregion

            #region while
            //Console.WriteLine("insert 0 if you want to exit");
            //string input = Console.ReadLine();
            //while (input != "0")
            //{
            //    Console.WriteLine($"you entered : {input}");
            //    Console.WriteLine("insert 0 if you want to exit");
            //    input = Console.ReadLine();
            //}

            //int num01;
            //Console.WriteLine("enter first number");
            //while (!int.TryParse(Console.ReadLine(), out /*int*/ num01))
            //{
            //    Console.WriteLine("invalid input, please enter valid integer");
            //}
            //num01++;
            #endregion

            #region do while
            //Console.WriteLine("insert 0 if you want to exit");
            //string input = Console.ReadLine();
            //while (input != "0")
            //{
            //    Console.WriteLine($"you entered : {input}");
            //    Console.WriteLine("insert 0 if you want to exit");
            //    input = Console.ReadLine();
            //}

            //string input;
            //do
            //{
            //    Console.WriteLine("insert 0 if you want to exit");
            //    input = Console.ReadLine();
            //    Console.WriteLine($"you entered : {input}");

            //} while (input != "0");

            #endregion

            #region foreach
            //List<string> names = new List<string>()
            //{
            //    "ali",
            //    "ahmed",
            //    "sara"
            //};

            //for (int i = 0; i < names.Count; i++)
            //{
            //    names[i] = "test";
            //    Console.WriteLine(names[i]);
            //}


            //foreach(string item in names)
            //{
            //    //item = "test";
            //    Console.WriteLine(item);
            //}
            #endregion

            //[quiz]rewrite the calculater program using while or do while

            //int num01, num02;
            //char op;
            //double result = 0;

            //Console.WriteLine("enter first number");
            //while (!int.TryParse(Console.ReadLine(), out num01))
            //{
            //    Console.WriteLine("invalid input");
            //}

            //Console.WriteLine("enter operation (+ - * / %)");
            //while (
            //    !(char.TryParse(Console.ReadLine(), out op)
            //    &&
            //    (op == '+' || op == '-' || op == '*' || op == '/' || op == '%')
            //    ))
            //{
            //    Console.WriteLine("invalid input");
            //}

            //Console.WriteLine("enter last number");
            //while (
            //    !int.TryParse(Console.ReadLine(), out num02)
            //    ||
            //    ((op == '/' || op == '%') && num02 == 0)
            //    )
            //{
            //    Console.WriteLine("invalid input");
            //}

            //switch (op)
            //{
            //    case '+': result = num01 + num02; break;
            //    case '-': result = num01 - num02; break;
            //    case '*': result = num01 * num02; break;
            //    case '/': result = (double)num01 / num02; break;
            //    case '%': result = num01 % num02; break;
            //    //default: result = 0; break;

            //}

            //Console.WriteLine($"{num01} {op} {num02} = {result}");
            #endregion

            #region Block scope
            //for (int i = 0; i < 10; i++)
            //{
            //    Console.WriteLine(i);
            //}
            //Console.WriteLine(i); //invalid [out of scope]

            //int z = 0;
            //for (z = 0; z < 10; z++)
            //{
            //    Console.WriteLine(z);
            //}
            //Console.WriteLine(z);

            //{
            //    int z = 0;
            //}

            //{
            //    int z = 0;
            //}
            //int z = 0;
            //Console.WriteLine(z);
            //bool result2 = !int.TryParse(Console.ReadLine(), out int num01);
            //while (!int.TryParse(Console.ReadLine(),out int num01))
            //{

            //    num01++;
            //}
            //Console.WriteLine(num01);//invalid [out of scope]

            //bool result = !int.TryParse(Console.ReadLine(), out int num02);
            //if (result)
            //{
            //    num02++;
            //}
            //Console.WriteLine(num02);
            #endregion

            #region Array
            #region one D array
            //int[] numbers;
            ////declare reference from type array of int in stack
            ////referring to null
            ////4 byte will be allocated in stack
            ////zero byte will be allocated in heap

            //numbers = new int[5];
            ////will allocate the required bytes in heap 20 byte [ 5 elements * 4 byte ]
            ////initilized with default value of it's data type [0]
            ////make reference to refer on address of object created in heap =. CLR


            //numbers = new int[5] { 1, 2, 3, 4, 5 };
            //numbers = new int[] { 1, 2, 3, 4, 5 , 6 , 7 };
            ////numbers = { 1,2,3,4,5,6}; //invalid
            ////int[] numbers02 = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            //Console.WriteLine(numbers.Length); //size of array

            //int[] numbers = new int[5];
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine($"please enter {i+1} element:");
            //    while(!int.TryParse(Console.ReadLine(),out numbers[i]))
            //    {
            //        Console.WriteLine($"invalid input,please enter a valid integer for {i + 1} element:");
            //    }
            //}

            //foreach (int item in numbers)
            //{
            //    //int.TryParse(Console.ReadLine(), out item); //invalid
            //    Console.WriteLine(item);
            //}
            #endregion
            #region two D array [Rectangler]
            //int[,] Marks;
            //Marks = new int[2, 4];// { { 1, 2, 3, 4 }, { 1, 2, 3, 4 } };
            ////int[] Marks = new int[5];
            //Console.WriteLine($"the size of array = {Marks.Length} , the number of dimensions = {Marks.Rank}");
            //Console.WriteLine($"numbers of rows = {Marks.GetLength(0)} , numbers of column = {(Marks.Rank > 1 ? Marks.GetLength(1) : "it's one D")}");

            /////read elments of arry from user 
            /////print elemnts of arry to user
            /////write program to do that with protictive code and readable messages
            //for (int i = 0; i < Marks.GetLength(0); i++) // 0  1 => rows
            //{
            //    for (int j = 0; j < Marks.GetLength(1); j++) // 0  1  2  3 => column
            //    {
            //        Console.WriteLine($"enter [{i} , {j}] element:");
            //        while (!int.TryParse(Console.ReadLine(),out Marks[i,j]))
            //        {
            //            Console.WriteLine($"invalid input, please enter valid integer for [{i} , {j}] element:");
            //        }
            //    }
            //}

            //foreach (int item in Marks)
            //{
            //    Console.WriteLine(item);
            //}

            //[quiz] write same program with only one loop

            #endregion
            #region Two D [Jaged Array]
            int[][,] numbers;
            numbers = new int[3][,];

            numbers[0] = new int[3, 5];
            numbers[1] = new int[1, 3];
            numbers[2] = new int[2, 1];

            Console.WriteLine($"the size of array = {numbers.Length} , the number of dimensions = {numbers.Rank}");
            Console.WriteLine($"numbers of rows = {numbers.GetLength(0)} , numbers of column = {(numbers.Rank > 1 ? numbers.GetLength(1) : "it's one D")}");

            Console.WriteLine($"the size of array = {numbers[0].Length} , the number of dimensions = {numbers[0].Rank}");
            Console.WriteLine($"numbers of rows = {numbers[0].GetLength(0)} , numbers of column = {(numbers[0].Rank > 1 ? numbers[0].GetLength(1) : "it's one D")}");

            for (int i = 0; i < numbers.Length; i++) //references
            {
                for (int j = 0; j < numbers[i].GetLength(0); j++) //=> rows
                {
                    for (int k = 0; k < numbers[i].GetLength(1); k++) //=> column
                    {
                        Console.WriteLine($"enter element [{i}][{j} , {k}]");
                        while (!int.TryParse(Console.ReadLine(),out numbers[i][j, k]))
                        {
                            Console.WriteLine($"invalid input, please enter a valid integer for element [{i}][{j} , {k}]");
                        } 
                    }
                }
            }

            foreach (int[,] item in numbers)
            {
                foreach (int  inneritem in item)
                {
                    Console.WriteLine(inneritem);
                }
            }

            #endregion
            #endregion

        }
    }
}
