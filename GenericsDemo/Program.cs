using System;
using System.Collections;
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
            Console.WriteLine("1.Without generic method\n2.With generic method\n3.With generic class\n4.Find maximum value");
            int option = Convert.ToInt32(Console.ReadLine());
            int[] arr = { 20, 30, 40 };
            double[] doublearr = { 20.67, 30, 40.34 };
            char[] chararr = { 'a', 'b', 'c', };
            int first = 30, second = 50, third = 60;
            switch (option)
            {
                case 1:
                    PrintArray.ToPrint(arr);
                    PrintArray.ToPrint(doublearr);
                    PrintArray.ToPrint(chararr);
                    Console.ReadLine();
                    break;
                case 2:
                    PrintGenericMethod.ToGenericPrint<int>(arr);
                    PrintGenericMethod.ToGenericPrint(doublearr);
                    PrintGenericMethod.ToGenericPrint(chararr);
                    Console.ReadLine();
                    break;
                case 3:
                    PrintGenericClass<int> obj1 = new PrintGenericClass<int>(arr);
                    obj1.ToPrint();
                    PrintGenericClass<double> obj2 = new PrintGenericClass<double>(doublearr);
                    obj2.ToPrint();
                    PrintGenericClass<char> obj3 = new PrintGenericClass<char>(chararr);
                    obj3.ToPrint();
                    Console.ReadLine();
                    break;
                case 4:
                    Console.WriteLine("{0} {1} {2}", first, second, third);
                    FindMaxValue.FindMaximumValue(first, second, third);
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
