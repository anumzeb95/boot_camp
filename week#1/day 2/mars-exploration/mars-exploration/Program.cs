using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mars_exploration
{
    internal class Program
    {

        static void Main(string[] args)
        {
            String s = "SOSSPSSQSSOR";
            int count = 0;


            for (int i = 0; i < s.Length; i+=3)
            {
                if (s[i] != 'S')
                {
                    count++;
                }
                if (s[i + 1] != 'O')
                {
                    count++;
                }
                if (s[i + 2] != 'S')
                {
                    count++;
                }
                
            }


            Console.WriteLine(" A space explorer's ship crashed and send a series of messages to Earth for help as: " + count);


            Console.ReadLine();



        }
    }
}
