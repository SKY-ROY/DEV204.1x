using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod2_Lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int counter = 0; counter < 5; counter++)
            {
                Console.WriteLine("Number: {0}", counter);
            }
            Console.WriteLine();
            int[] ar = new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            foreach(int num in ar)
            {
                Console.WriteLine($"Counter is at: {num}");
            }
            Console.WriteLine();
            for (int i=0; i<10; i++)
            {
                for(int j=0; j<10; j++)
                {
                    Console.Write($"{j} ");
                }
                Console.WriteLine();
            }
        }
    }
}
