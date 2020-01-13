using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod2_Lab4
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 1;
            while(n!=6)
            {
                Console.WriteLine($"value: {n++}");
            }
            Console.WriteLine();
            n = 0;
            do
            {
                Console.WriteLine($"value: {n++}");
            } while (n != 6);
        }
    }
}
