using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interface_task
{
    internal class Program
    {
        static void Main(string[] args)
        {

           Console.WriteLine("Just takes an integer as input for the sum of all its divisors: ");

           MyCalculator calculator = new MyCalculator();
           
            int n= Convert.ToInt32(Console.ReadLine());
            int sum = calculator.divisior_sum(n);
           Console.WriteLine ("AdvancedArithmetic: \n" + sum);

            Console.ReadLine();
        }
    }
}
