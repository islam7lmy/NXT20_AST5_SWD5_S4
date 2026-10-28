using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Interfaces
{
    internal interface ISeries
    {
        int Current { get; }
        void GetNext();
        void Reset();
    }

    class SeriesByTwo : ISeries
    {
        public int Current { get; private set; }

        public void GetNext()
        {
            Current += 2;
        }

        public void Reset()
        {
            Current = 0;
        }
    }

    class SeriesByThree : ISeries
    {
        public int Current { get; private set; }

        public void GetNext()
        {
            Current += 3;
        }
        public void Reset()
        {
            Current = 0;
        }
    }

    class SeriesByFive : ISeries
    {
        public int Current { get; private set; }

        public void GetNext()
        {
            Current += 5;
        }
        public void Reset()
        {
            Current = 0;
        }
    }

    class SeriesBySeven : ISeries
    {
        public int Current { get; private set; }

        public void GetNext()
        {
            Current += 7;
        }
        public void Reset()
        {
            Current = 0;
        }
    }
}
