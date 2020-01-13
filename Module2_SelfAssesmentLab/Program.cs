using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2_SelfAssesmentLab
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int i=0; i<8; i++)
            {
                for(int j = i+0; j < i+8; j++)
                {
                    if (j % 2 == 0)
                        Console.Write("X ");
                    else
                        Console.Write("O ");
                }
                Console.WriteLine();
            }
        }
    }
}
