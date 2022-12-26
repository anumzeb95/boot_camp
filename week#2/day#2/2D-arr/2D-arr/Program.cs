using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2D_arr
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[,] x = new int[6, 6] { { 0,0,0,0,0,0 } , { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 10, 10, 10 }, { 0, 0, 50, 0, 10, 0 }, { 0, 0, 0, 5,5,5} };

           
            int[,] arsum = new int[4,4];
            int mx = 0;
            

            for( int i=0; i<4; i++)
            {
                for (int j=0; j<4; j++)
                {
                    arsum[i, j] = x[i,j] + x[i,j+1] + x[i,j+2] + x[i+1,j+1] + x[i+2,j] + x[i+2,j+1] + x[i+2,j+2];
                    if (arsum[i,j] >mx)
                    {
                       mx = arsum[i,j];

                    }
                   
                    
                }
            }
            Console.WriteLine(mx);







            Console.ReadLine();
            Console.ReadKey();




        }
    }
}
