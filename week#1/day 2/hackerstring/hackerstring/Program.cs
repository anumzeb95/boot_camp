using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hackerstring
{
    internal class Program
    {
        

        static void Main(string[] args)
        {


            char[] hr = new char[10] { 'h', 'a', 'c', 'k', 'e', 'r', 'r', 'a', 'n', 'k' };
          
            string a = "hereiamstackerrank";
            //String b = "hackerworld";
            bool status= false;

           
                    

                for (int i = 0; i < a.Length - 1; i++)
                {

                    for (int j = 0; j < hr.Length; j++)
                    {
                        if (a[i] == hr[j])
                        {
                            status = true;
                            break;
                        }
                        else
                    {
                        status &= false;
                    }

                    }

                }
            
            Console.WriteLine("So the status of the string: " + (status ? "YES" : "NO"));

            
          
           





            Console.ReadLine(); 

            
        }
    }
}
