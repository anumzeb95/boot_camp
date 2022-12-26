using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace staircase
{
    internal class Program
    {

        public static void Main(string[] args)
        {
            //staircase s= new staircase();

            int n = 4;
            int x, y;
            for (x = 1; x <= n; x++)
            {
                for (y = 1; y <= x; y++)
                {
                    Console.Write("#");
                }
                Console.Write("\n");
                

            }
            Console.ReadLine();
        }

    }
}
