using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] num = { 1, 2, 3, 4, 10, 11 };
           
            Console.WriteLine("Total size of element :"+ num.Length);
            Console.WriteLine("Sum :" + num.Sum());
            
            Console.ReadLine();
        }
    }
}
