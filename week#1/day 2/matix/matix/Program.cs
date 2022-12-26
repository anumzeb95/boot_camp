using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace matix
{
    internal class Program
    {
        public static int difference(int[,] arr,
                               int n)
        {
            int d1 = 0;
            int d2 = 0;

            for (int i = 0; i < n; i++)
            {
                d1 += arr[i, i]; ;
                d2 += arr[i, n - i - 1];
            }

            return Math.Abs(d1 - d2);

        }


            static void Main(string[] args)
        {
            int n = 3;
            int[,] arr = { { 11, 2, 4 }, { 4, 5, 6 }, { 10, 8, -12 } };
           

            Console.WriteLine(difference(arr, n));
            Console.ReadLine();


            }
    }
}
