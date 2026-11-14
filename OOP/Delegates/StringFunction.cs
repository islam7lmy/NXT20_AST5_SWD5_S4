using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Delegates
{
    internal static class StringFunction
    {
        public static int CountUppercase(string str)
        {
            int count = 0;

            foreach (char c in str)
            {
                if (char.IsUpper(c))
                    count++;
            }

            return count;
        }

        public static int CountLowercase(string str)
        {
            int count = 0;

            foreach (char c in str)
            {
                if (char.IsLower(c))
                    count++;
            }

            return count;
        }
    }
}
