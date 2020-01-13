using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod2_Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter an Integer value and press Enter.");
            int input = Int32.Parse(Console.ReadLine());

            if(input%2 == 0)
            {
                Console.WriteLine("{0} is an even number.", input);
            }
            else
            {
                Console.WriteLine("{0} is an odd number.", input);
            }
        }
    }
}
