using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsDemo
{
    public class MaxValueGeneric<T> where T : IComparable
    {
        public T x, y, z;
        public MaxValueGeneric(T a,T b,T c)
        {
            x = a;
            y = b;
            z = c;

        }
        public static T FindMaximumValue(T first, T second, T third)
        {
            int res = first.CompareTo(second);
            if (first.CompareTo(second) >= 0 && first.CompareTo(third) >= 0)
            {
                Console.WriteLine("{0} is greater", first);
                return first;
               
            }
            else if (second.CompareTo(first) >= 0 && second.CompareTo(third) >= 0)
            {
                Console.WriteLine("{0} is greater", second);
                return second;
                
            }
            else
            {
                Console.WriteLine("{0} is greater", third);
                return third;
               
            }
        }

        public void TestMaxValue()
        {
            T res = FindMaximumValue(x, y, z);
            if(!(res.Equals(0)) || (res.Equals(null)))
            {
                Console.WriteLine("Max Value" + res);
            }
        }
    }
}
