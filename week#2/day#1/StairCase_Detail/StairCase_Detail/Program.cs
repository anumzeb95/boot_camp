using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StairCase_Detail
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            for (int i = 6; i >= 1; i--)
            {
                for (int j = 1; j < i; j++)
                {
                    Console.Write(" ");
                }
                for (int n = 6; n >= i; n--)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
    
}
