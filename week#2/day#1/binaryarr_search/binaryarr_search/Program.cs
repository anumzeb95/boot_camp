using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace binaryarr_search
{
    internal class Program
    {
        static int binarySearch(int[] arr, int l, int r, int x)

        {
            if (r >= l)
            {
                int mid = l + (r - l) / 2;
        
                if (arr[mid] == x)
                    return mid;
              
             
                if (arr[mid] > x)
                    return binarySearch(arr, l, mid - 1, x);
               
                return binarySearch(arr, mid + 1, r, x);
}
            
            return -1;
        }


        public static void Main(string[] args)
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

            admin ad = new admin();
            Console.WriteLine("My name is " + s.name + ". " + "My  age is " + s.age + ".");
            ad.abc();

            staff st = new staff();
            Console.WriteLine("My name is " + t.name + ". " + "My  age is " + t.age + ".");
            st.abc();

            Guard g = new Guard();
            Console.WriteLine("My name is " + p.name + ". " + "My  age is " + p.age + ".");
            g.abc();


            //Console.WriteLine("Enter a number:");
           // int x =

            int[] arr = { 18, 34, 38, 42, 58, 60 };
            int n = arr.Length;
            Console.WriteLine("\n" + "Enter a number:");
            int x = Convert.ToInt32(Console.ReadLine());

            int result = binarySearch(arr, 0, n - 1, x);
            if (result == -1)
                Console.WriteLine("Element not present");
            else
                Console.WriteLine("Element found at index "
                + result);



            Console.ReadLine();

        }
    }
}

