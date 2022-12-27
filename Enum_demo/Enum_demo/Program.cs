using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enum_demo
{
    public enum years_name
    {
        //Values(jan) & key(1) etc
        //casting and assigning keys explcitly(e.g. int), by default enum type is int but we can change it, byte(8 bits), key-pair values
        January = 1,
        February=2,
        March=3,
        April=4,
        May=5, 
        June=6, 
        July=7, 
        August=8, 
        September=9, 
        October=10,
        November=11, 
        December=12
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Year name is:");


            foreach (var temp in Enum.GetValues(typeof(years_name)))
            {
                Console.WriteLine("=> "+ (int)temp);//explicit casting key
                Console.WriteLine(temp);
            }
            
            Console.ReadLine();
        }
    }
}
