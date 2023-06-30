using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsDemo
{
    internal class FindMaxValue
    {
        public static void FindMaximumValue(int first, int second, int third)
        {
            int res = first.CompareTo(second);
            if(first.CompareTo(second) >= 0 && first.CompareTo(third)>=0)
            {
                Console.WriteLine("{0} is greater", first);
            }
            else if(second.CompareTo(first)>=0 && second.CompareTo(third)>=0)
            {
                Console.WriteLine("{0} is greater", second);
            }
            else
            {
                Console.WriteLine("{0} is greater", third);
            }
        }

        public static void FindMaximumValue(float first, float second, float third)
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
