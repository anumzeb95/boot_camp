using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlusMinus
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[] arr = { 2, -1, 5, 6, 0, -3 };
            int lengthOfNumbers = arr.Length;
            
            float pos_count = 0;
            float neg_count = 0;
            float zero_count = 0;

            for (int i = 0; i < lengthOfNumbers; i++)
            {
                if (arr[i] == 0)
                {
                    zero_count++;
                }

                else if (arr[i] < 0)
                {
                    neg_count++;
                }
                else if(arr[i] > 0)
                {
                    pos_count++;
                }

            }

            Console.WriteLine(arr.Length);
            Console.WriteLine(zero_count/ lengthOfNumbers);
            Console.WriteLine(neg_count/ lengthOfNumbers);
            Console.WriteLine(pos_count/ lengthOfNumbers);
            




            Console.ReadLine();






        }
    }
}
