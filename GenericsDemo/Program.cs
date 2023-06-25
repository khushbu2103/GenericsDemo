using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("please select any program");
            Console.WriteLine("1.Without generic method\n2.With generic method");
            int option = Convert.ToInt32(Console.ReadLine());
            int[] arr = { 20, 30, 40 };
            double[] doublearr = { 20.67, 30, 40.34 };
            char[] chararr = { 'a', 'b', 'c', };
            switch (option)
            {
                case 1:
                    PrintArray.ToPrint(arr);
                    PrintArray.ToPrint(doublearr);
                    PrintArray.ToPrint(chararr);
                    Console.ReadLine();
                    break;
               
                default:
                    {
                        Console.WriteLine("please choose given number");
                        break;
                    }
                   
            }
           

           
        }
    }
}
