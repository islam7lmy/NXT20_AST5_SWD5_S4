using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commen
{
    public interface ISeries
    {
        int Current { get; }

        void GetNext();
        void Reset();
    }

    public abstract class SeriesBase : ISeries
    {
        ///private
        ///Private Protected => me and my sub classes => must be in same assembly
        ///protected =>  me and my sub classes => in any assembly
        ///internal
        ///protected internal => me and my sub classes => in any assembly, and call it outer your sub class in same assembly
        ///public


        //implmented
        //public int Current { get; private protected set; }
        public int Current { get; protected set; }
        //public int Current { get; protected internal set; }

        //not fully implmented
        public abstract void GetNext();

        //implmented
        public void Reset()
        {
            Current = 0;
        }
    }
    public class SeriesByTwo : SeriesBase
    {
        public override void GetNext()
        {
            Current += 2;
        }
    }

    class test
    {
        void test2()
        {
            SeriesByTwo seriesByTwo = new SeriesByTwo();
            //seriesByTwo.Current = 20; //not valid => private protected
            //seriesByTwo.Current = 20; //not valid => protected
            //seriesByTwo.Current = 20; //valid => protected internal
        }
    }
}
