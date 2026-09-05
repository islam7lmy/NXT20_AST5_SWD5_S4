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
            #endregion
        }
    }
}
