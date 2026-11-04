using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.OperatorOverloading
{
    internal class Complex
    {
        public int Real { get; set; }
        public int Imag { get; set; }
        public Complex(int real, int imag)
        {
            Real = real;
            Imag = imag;
        }

        public override string ToString()
        {
            return $"{Real} + {Imag}i";
        }

        public static Complex operator +(Complex a, Complex b)
        {
            int RealPart = (a?.Real ?? 0) + (b?.Real ?? 0);
            int ImagPart = (a?.Imag ?? 0) + (b?.Imag ?? 0);
            Complex result = new Complex(RealPart, ImagPart);
            return result;
        }

        public static Complex operator -(Complex a, Complex b)
        {
            int RealPart = (a?.Real ?? 0) - (b?.Real ?? 0);
            int ImagPart = (a?.Imag ?? 0) - (b?.Imag ?? 0);
            Complex result = new Complex(RealPart, ImagPart);
            return result;
        }

        public static Complex operator ++(Complex a)
        {
            int RealPart = (a?.Real ?? 0) + 1;
            int ImagPart = (a?.Imag ?? 0) + 1;
            Complex result = new Complex(RealPart, ImagPart);
            return result;
        }

        public static Complex operator --(Complex a)
        {
            int RealPart = (a?.Real ?? 0) - 1;
            int ImagPart = (a?.Imag ?? 0) - 1;
            Complex result = new Complex(RealPart, ImagPart);
            return result;
        }

        //[quiz]
        //>
        //==
    }
}
