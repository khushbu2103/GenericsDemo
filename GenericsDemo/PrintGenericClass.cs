
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsDemo
{
    internal class PrintGenericClass<T>
    {
        public T[] arr;

        public PrintGenericClass(T[] arr)
        {
            this.arr = arr;
        }
        public void ToPrint()
        {
            Console.WriteLine("\nArray Element");
            foreach (var element in arr)
            {
                Console.Write(element + " ");
            }
        }
       
    }
}
