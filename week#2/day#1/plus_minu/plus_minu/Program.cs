using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace plus_minu
{
    internal class Program
    {
        static void Main(string[] args)
        {

             
            int[] arr = new int[] { -4, 3, -9, 0, 4, 1 };
            int len= arr.Length;

            float pos_Count = 0;
            float neg_Count = 0;
            float zero_Count = 0;

            for (int i = 0; i < len; i++)
            {
                if (arr[i] > 0)
                {
                    pos_Count++;
                }
                if (arr[i] < 0)
                {
                    neg_Count++;
                }
                if (arr[i] == 0)
                {
                    zero_Count++;
                }

            }

            Console.WriteLine("Positove Count: "+ pos_Count / len);
            Console.WriteLine("Negatiove Count: "+ neg_Count / len);
            Console.WriteLine("Zero Count: "+ zero_Count/ len);



            Console.ReadLine();



        }
    }
}
