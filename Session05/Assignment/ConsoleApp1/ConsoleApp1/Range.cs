using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Range<T> where T : IComparable<T>
    {
        public T Min { get; set; }
        public T Max { get; set; }
        public Range(T _Min, T _Max)
        {
            Min = _Min;
            Max = _Max;
        }
        public bool IsInRange(T Number)
        {
            if (Number.CompareTo(Min) >= 0 && Number.CompareTo(Max) <= 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public T Legnth()
        {
            return ((dynamic)Max - (dynamic)Min);
        }
    }
}
