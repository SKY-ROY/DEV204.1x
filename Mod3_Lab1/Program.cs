using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod3_Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            //sum(10, 59);
            Console.WriteLine($"{Sum(10, 59)}");
            Console.WriteLine($"{Sum(10, 59, 10)}");
            Console.WriteLine($"{Sum(2.5)}");

        }
        static int Sum(int first, int second)
        {
            int sum = first + second;
            //Console.WriteLine($"the sum of {first} and {second} is {sum}");
            return sum;
        }
        static int Sum(int f, int s, int t)
        {
            int sum = f + s + t;
            return sum;
        }
        static double Sum(double num)
        {
            double sum = 5 * num;
            return sum;
        }
    }
}
