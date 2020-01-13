using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod3_Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            int first, second;
            
            Console.WriteLine("Enter value for numerator:");
            first = Int32.Parse(Console.ReadLine());
            
            Console.WriteLine("Enter value for denominator:");
            second = Int32.Parse(Console.ReadLine());
            
            int res = Divide(first, second);
            Console.WriteLine($"The result of {first} and {second} is {res}.");
        }
        static int Divide(int numerator, int denominator)
        {
            int result = 0;
            try
            {
                result = numerator / denominator;
            }
            catch(DivideByZeroException ex)
            {
                Console.WriteLine("Cannot divide by zero, provide non-zero value for denominator.");
            }
                
            return result;
        }
    }
}
