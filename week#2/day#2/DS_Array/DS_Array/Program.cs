using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[4] { 1, 4, 3, 2 };

            Array.Reverse(array); // reverse the array

            Console.Write("Reversed Array: ");
            
            foreach (int i in array)
            {
                Console.Write(i + " ");
            }

            Console.ReadLine();
        }
    }
}