using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lineararr_search
{
    internal class Program
    {
        public static int search(int[] age, int x)
        {
            int num = age.Length;
            for (int i = 0; i < num; i++)
            {
                if (age[i] == x)
                    return i;
            }
           return -1;
        }

        static void Main(string[] args)
        {
            student s = new student();
            Console.WriteLine("My name is " + s.name + ". " + "My  age is " + s.age + ".");
            s.abc();

            teacher t = new teacher();
            Console.WriteLine("My name is " + t.name + ". " + "My  age is " + t.age + ".");
            t.abc();

            Principal p = new Principal();
            Console.WriteLine("My name is " + p.name + ". " + "My  age is " + p.age + ".");
            p.abc();


           
            int[] age= { 18, 34, 58 };
            
            int x = 34;
            int result = search(age, x);
            if (result == -1)
                Console.WriteLine(
                    "Element is not present in array");
            else
                Console.WriteLine("Element is present at index:  "
                                  + result);

            Console.ReadLine();

        }
    }
}
