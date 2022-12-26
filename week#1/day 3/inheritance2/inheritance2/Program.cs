using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            val v = new val();

           int result=  v.add(v.x, v.y);
            Console.WriteLine(result);


            Console.ReadLine();

        }
    }
}
