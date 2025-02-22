using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] massiv = new int[6];
            Input(massiv);
            Output(massiv);
            Check(massiv);
            Console.ReadKey();
        }
        static void Input(int[] massiv)
        {
            
            Random x = new Random();
            for(int i = 0; i < massiv.Length; i++)
            {
                Console.WriteLine($"massiv[{i}]= ");
                massiv[i] = x.Next(-10,10);
            }

        }
        static void Output(int[] massiv)
        {
            foreach (var i in massiv)
            {
                Console.WriteLine($"{i}\t");
            }
        }
        static void Check(int[] massiv)
        {
            int a = 0;
            foreach(var i in massiv)
            {
                if (i % 2 == 0)
                {
                    a++;
                }
            }
            Console.WriteLine($"Количество чётных чисел= {a}");
        }
    }
}
