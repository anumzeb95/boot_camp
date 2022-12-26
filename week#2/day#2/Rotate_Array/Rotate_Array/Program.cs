using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rotate_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[5] {1,2,3,4,5};
            int d =4;


            for (int i = 0; i < array.Length-1; i++)
            {
                d = array[0];
                array[0] = array[i + 1];
                array[i + 1] = d;
            }



            Console.WriteLine("Array of integers rotation: ");
            foreach (int n in array)
            {
                Console.Write(n + " ");
            }

            Console.ReadLine();
        }
    }
}
