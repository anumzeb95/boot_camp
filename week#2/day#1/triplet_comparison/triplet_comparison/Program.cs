using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace triplet_comparison
{
    internal class Program
    {

        static void Main(string[] args)
        {
            int[] alice = { 1, 2, 3 };
            int[] bob =  { 3, 2, 1 };
            //int totalTest = 3;


            int a = 0;
            int b = 0;

            for (int i = 0; i < alice.Length; i++) //compare
            {
                if (alice[i] > bob[i])
                {
                    a++;
                }
                if (alice[i] < bob[i])
                {
                    b++;
                }
               

            }
            int[] sum= {a,b}; 
            foreach(int i in sum) //array print
            {
                Console.WriteLine(sum[i]);
            }

            Console.ReadLine();

        }
    }
}


    



