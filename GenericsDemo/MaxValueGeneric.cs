using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsDemo
{
    public class MaxValueGeneric<T> where T : IComparable
    {
        public static void FindMaximumValue(T first, T second, T third)
        {
            int res = first.CompareTo(second);
            if (first.CompareTo(second) >= 0 && first.CompareTo(third) >= 0)
            {
                Console.WriteLine("{0} is greater", first);
               
            }
            else if (second.CompareTo(first) >= 0 && second.CompareTo(third) >= 0)
            {
                Console.WriteLine("{0} is greater", second);
                
            }
            else
            {
                Console.WriteLine("{0} is greater", third);
               
            }
        }
    }
}
