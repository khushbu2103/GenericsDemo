using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsDemo
{
    internal class PrintArray
    {
        public static void ToPrint(int[] intArray)
        {
            Console.WriteLine("\nInteger array Elements");
            foreach(int elements in intArray)
            {
                Console.Write(elements + " ");
            }
          
        }

        public static void ToPrint(double[] doubleArray)
        {
            Console.WriteLine("\nDouble array Elements");
            foreach (double elements in doubleArray)
            {
                Console.Write(elements + " ");
            }

        }

        public static void ToPrint(char[] charArray)
        {
            Console.WriteLine("\nString array elements");
            foreach (char elements in charArray)
            {
                Console.Write(elements + " ");
            }
        }

       

    }

}
