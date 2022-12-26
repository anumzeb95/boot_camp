using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diagonal_Difference
{
    internal class Program
    {
        public static int difference(int[,] arr, int n)
        {
            int a = 0;
            int b = 0;
            for (int i = 0; i < n; i++)
            {
                a += arr[i, i]; ;
                b += arr[i, n - i - 1];
            }
            return Math.Abs(a - b);
        }
        static void Main(string[] args)
        {
            int n = 3;
            int[,] arr = { { 1,2,3 }, { 4, 5, 6 }, { 9,8,9 } };

            Console.WriteLine("The absolute difference of the square matrix :" );
            Console.WriteLine(difference(arr, n));
            Console.ReadLine();


        }
    }
}
