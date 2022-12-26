using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Migratory_Birds
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[] arr = new int[5] { 4,4,2,2,3 };
            
            int min= arr.Length;
           
            for (int i =0; i < arr.Length; i++)
            {
                for (int j= i+1; j < arr.Length; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        Console.WriteLine("Duplicate values in given array: " + arr[i] + "\n");
                    }

                    if (arr[i] < min)
                    {
                        min = arr[i];
                        
                    }
                } 
            }

            Console.WriteLine("Smallest value in given array: " + min);


            Console.ReadLine();

        }
    }
}
