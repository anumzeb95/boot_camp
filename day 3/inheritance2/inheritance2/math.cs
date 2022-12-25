using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance2
{
    internal class math
    {
        public int add (int x , int y)
        {
            int sum;
            sum = x + y;
            return sum;

        }
       
    }
    internal class val : math
    {
        public int x = 42;
        public int y = 83;

    }
}
