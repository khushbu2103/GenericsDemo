using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsDemo
{
    internal class PrintGenericMethod
    {
        //we can use generic method instead to this normal method

        public static void ToGenericPrint<T>(T[] array)
        {
            Console.WriteLine("\nArray Element");
            foreach (T element in array)
            {
                Console.Write(element + " ");
            }

        }
    }
}
