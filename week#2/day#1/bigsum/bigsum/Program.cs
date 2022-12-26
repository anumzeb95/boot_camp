using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bigsum
{
    internal class Program
    {
        static int getSum(int num)
        {
            int sum = 0;

            while (num != 0)
            {
                sum = sum + num % 10;
                num = num / 10;
            }

            return sum;
        }
        static void Main(string[] args)
        {
           Int64 [] array = {1000000001, 1000000002, 1000000003, 1000000004, 1000000005};

            Int64 sum= array.Sum();


            Console.WriteLine("Total size of element :" + array.Length);
            Console.WriteLine("sum :" + sum);  
            


            Console.ReadLine();


        }
    }
}
