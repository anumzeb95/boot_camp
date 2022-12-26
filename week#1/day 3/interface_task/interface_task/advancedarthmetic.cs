using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interface_task
{
    interface IAdvanceArthmetic
    {
        int divisior_sum(int n);
    }
    class MyCalculator : IAdvanceArthmetic
    {
        
        public int divisior_sum (int n)
            
        {
            int sum = 0; ;
            int N = n;
            for (int i = 1; i <= N; i++)
            {
                if (n % i == 0)
                {
                    sum = sum + i;
                }
            }

            return sum;

        }
    }
}
