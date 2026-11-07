using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.OperatorOverloading
{
    internal class Complex
    {
        public Complex(int real, int imag)
        {
            Real = real;
            Imag = imag;
        }

        public int Real { get; set; }
        public int Imag { get; set; }
        //public Complex(int real, int imag)
        //{
        //    Real = real;
        //    Imag = imag;
        //}

        public override string ToString()
        {
            return $"{Real} + {Imag}i";
        }

        public override bool Equals(object? obj)
        {
            return obj is Complex complex &&
                   Real == complex.Real &&
                   Imag == complex.Imag;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Real, Imag);
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
        public static bool operator >(Complex a, Complex b)
        {
            if ((a?.Real ?? 0) == (b?.Real ?? 0))
                return (a?.Imag ?? 0) > (b?.Imag ?? 0);
            return (a?.Real ?? 0) > (b?.Real ?? 0);
        }

        public static bool operator <(Complex a, Complex b)
        {
            if ((a?.Real ?? 0) == (b?.Real ?? 0))
                return (a?.Imag ?? 0) < (b?.Imag ?? 0);
            return (a?.Real ?? 0) < (b?.Real ?? 0);
        }

        public static bool operator ==(Complex? left, Complex? right)
        {
            return EqualityComparer<Complex>.Default.Equals(left, right);
        }

        public static bool operator !=(Complex? left, Complex? right)
        {
            return !(left == right);
        }

        //==
        //public static bool operator ==(Complex a, Complex b)
        //{
        //    return a.Equals(b);
        //}
        //public static bool operator !=(Complex a, Complex b)
        //{
        //    return !(a == b);
        //}

        //public override bool Equals(object? obj)
        //{
        //    //this keyword => refer to caller of method
        //    //obj
        //    Complex b = (Complex)obj; //[unsafe casting]

        //    if ((this?.Real ?? 0) == (b?.Real ?? 0))
        //        return (this?.Imag ?? 0) == (b?.Imag ?? 0);
        //    return false;
        //}

        //public override int GetHashCode()
        //{
        //    return HashCode.Combine(Real, Imag);

        //}

    }
}
