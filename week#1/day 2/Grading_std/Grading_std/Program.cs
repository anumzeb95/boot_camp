using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grading_std
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Enter student marks: ");
            
            int grade = Convert.ToInt32(Console.ReadLine());


            if ( grade % 5 < 3)
            {
                int n = grade % 5;
                grade = grade + n;
                
                    grade += 5 - (grade % 5);

                    Console.WriteLine(" Your marks is rounded of:" + grade);
                
            }

            else if (grade % 5 == 3)
            {
                Console.WriteLine(" Your marks:" + grade);
            }
            else if (grade % 5 > 3)
            {
                Console.WriteLine(" Your marks:" + grade);
            }
            

            Console.ReadLine();

        }
    }
}
