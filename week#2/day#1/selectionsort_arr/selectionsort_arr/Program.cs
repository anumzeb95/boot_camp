using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace selectionsort_arr
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[] array = { 8, 7, 9 ,2, 3, 1, 5, 10, 20,4, 6, 40 };

            Array.Sort(array);

            Console.WriteLine("Implement the Selection Sort algorithm: \n ");

            foreach (int i in array)
            {
                Console.WriteLine( i);
            }


           Console.ReadLine(); 

        }
        public static void SelectionSort(int[] array)
        {
            for(int i=0; i <array.Length-1; i++)
            {
                int min = i;
                for(int j=i+1; j <array.Length; j++)
                {
                    if (array[min]> array[j])
                    {
                        min = j;
                    }
                }
                int temp = array[i];
                array[i] = array[min];
                array[min] = temp;
            }
            

        }
    }
}
