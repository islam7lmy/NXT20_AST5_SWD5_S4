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
            int X;
            ///allocate 4 uninitialized bytes in stack
            ///int : C# Keyword

            //Console.WriteLine(X);// invalid

            X = 5;

            //Console.WriteLine(X);

            Int32 Y;
            ///allocate 4 uninitialized bytes in stack
            ///Int32 : CLS Keyword

            Y = X;

            X = X + 1;

            Console.WriteLine($"X:{X}"); // 6
            Console.WriteLine($"Y:{Y}"); // 5
            #endregion
        }
    }
}
