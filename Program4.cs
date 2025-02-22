using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] mass=new int[] { 3, 7, 12, 5, 18, 1, 9, 20, 15 };
            Output(mass);
            Console.ReadKey();
            
        }

        static void Output(int[] mass)
        {
            Console.Write("Введите число= ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Индексы элементов, больших заданного числа:");
            for (int i = 0; i <mass.Length; i++)
            {
                if (mass[i] >= a)
                {
                    Console.Write($"{i}\t");
                }
                    
            }
        }

    }
}
